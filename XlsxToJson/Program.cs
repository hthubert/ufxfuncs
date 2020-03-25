using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ExcelDataReader;
using hundsun.mcapi;
using hundsun.t2sdk;
using Newtonsoft.Json;
using QuantBox.XApi;

namespace XlsxToJson
{
    public class Cb2 : CT2CallbackInterface
    {
        public override void OnConnect(CT2Connection lpConnection)
        {
            throw new NotImplementedException();
        }

        public override void OnSafeConnect(CT2Connection lpConnection)
        {
            throw new NotImplementedException();
        }

        public override void OnRegister(CT2Connection lpConnection)
        {
            throw new NotImplementedException();
        }

        public override void OnClose(CT2Connection lpConnection)
        {
            throw new NotImplementedException();
        }

        public override unsafe void OnSent(CT2Connection lpConnection, int hSend, void* lpData, int nLength, int nQueuingData)
        {
            throw new NotImplementedException();
        }

        public override void OnReceivedBiz(CT2Connection lpConnection, int hSend, string lppStr, CT2UnPacker lppUnPacker, int nResult)
        {
            throw new NotImplementedException();
        }

        public override void OnReceivedBizEx(CT2Connection lpConnection, int hSend, CT2RespondData lpRetData, string lppStr,
            CT2UnPacker lppUnPacker, int nResult)
        {
            throw new NotImplementedException();
            //lpConnection.
        }

        public override void OnReceivedBizMsg(CT2Connection lpConnection, int hSend, CT2BizMessage lpMsg)
        {
            throw new NotImplementedException();
        }
    }
    
    public class UfxFunctionArg
    {
        public string Name;
        public string Type;
        public string Description;
        public bool Required;
        public string Remark;
        public override string ToString()
        {
            return $"{Name},{Type},{Remark}";
        }
    }

    public class UfxFunction
    {
        public int Code;
        public sbyte MsgType;
        public int OldCode;
        public string UpdateDate;
        public string Name;
        public string FunctionName;
        public string Version;
        public bool HasDataSet;
        public string BusinessScope;
        public string InterfaceScope;
        public string RequestType;
        public string Status;
        public string Description;
        public readonly List<UfxFunctionArg> InArgs = new List<UfxFunctionArg>();
        public readonly List<UfxFunctionArg> OutArgs = new List<UfxFunctionArg>();
        public string BusinessDescription;
        public override string ToString()
        {
            return Code == 0 ? $"消息推送:{MsgType},{Name},{FunctionName},{Description}" : $"功能接口:{Code},{Name},{FunctionName},{Description}";
        }
    }

    public class DataDictItem
    {
        public string Value;
        public string Description;
    }

    public class DataDict
    {
        public string Key;
        public string Description;
        public string Name;
        public List<DataDictItem> Items = new List<DataDictItem>();
    }

    public class ErrorInfo
    {
        public int Code;
        public string Message;
        public string Remark;
    }

    sealed class Program
    {
        private const int B = 1;
        private const int C = 2;
        private const int D = 3;
        private const int E = 4;
        private const int F = 5;
        private const int G = 6;

        private static string NameToEn(string name)
        {
            var map = new List<(string cn, string en)>
            {
                ("委托", "Entrust"),
                ("下达", "Received"),
                ("确认", "Confirmed"),
                ("废单", "Rejected"),
                ("撤单", "Cancel"),
                ("撤成", "Cancelled"),
                ("撤废", "CancelRejected"),
                ("成交", "Trade"),
                ("合笔", "Combi"),
                ("股票期权组合保证金", "CombiOptions"),
                ("股票期权组合", "CombiOptions"),
                ("待审批", "Approving"),
                ("审批", "Approving"),
                ("商品期权组合单", "CombiFutureOptions"),
                ("上交所合并行权", "ShCombiExercise")
            };
            map.Sort((x, y) => y.cn.Length.CompareTo(x.cn.Length));
            foreach (var (cn, en) in map)
            {
                name = name.Replace(cn, en);
            }
            return name;
        }

        private static UfxFunction ParseFunction(IExcelDataReader reader)
        {
            var func = new UfxFunction();
            //第1行
            if (reader.GetString(B) == "功能号")
            {
                func.Code = int.Parse(reader.GetValue(C).ToString());
                if (int.TryParse(reader.GetValue(E)?.ToString(), out var oldCode))
                {
                    func.OldCode = oldCode;
                }
            }
            else
            {
                //消息推送
                func.MsgType = (sbyte)reader.GetValue(C).ToString()[0];
            }

            func.UpdateDate = reader.GetValue(G).ToString();
            //第2行
            reader.Read();
            func.Name = ConvertToEn(reader.GetString(C));
            func.Version = reader.GetValue(E).ToString();
            func.HasDataSet = reader.GetString(G) == "Y";
            //第3行
            reader.Read();
            func.FunctionName = reader.GetString(C);
            if (func.MsgType > 0)
            {
                func.FunctionName = NameToEn(func.Name);
            }
            func.RequestType = reader.GetString(G);
            //第4行
            reader.Read();
            func.BusinessScope = reader.GetString(C);
            if (func.Code == 0)
            {
                //消息推送-接口范围
                func.InterfaceScope = reader.GetString(E);
            }

            func.Status = reader.GetString(G);
            //第5行
            reader.Read();
            func.Description = ConvertToEn(reader.GetString(C));
            //输入输出参数
            reader.Read();
            var exit = false;
            while (!exit)
            {
                var flag = reader.GetString(B);
                switch (flag)
                {
                    case "输入参数":
                    case "订阅参数":
                        ReadArgList(func.InArgs, reader);
                        break;
                    case "输出参数":
                        ReadArgList(func.OutArgs, reader);
                        break;
                    case "业务说明":
                        reader.Read();
                        func.BusinessDescription = ConvertToEn(reader.GetString(C));
                        reader.Read();
                        break;
                    case "出错说明":
                        exit = true;
                        break;
                    default:
                        MoveToNextFlag(reader);
                        break;
                }
            }
            return func;
        }

        private static void MoveToNextFlag(IExcelDataReader reader)
        {
            while (true)
            {
                reader.Read();
                if (!string.IsNullOrEmpty(reader.GetString(B)))
                {
                    break;
                }
            }
        }

        private static void ReadArgList(List<UfxFunctionArg> args, IExcelDataReader reader)
        {
            while (true)
            {
                reader.Read();
                var flag = reader.GetString(B);
                if (!string.IsNullOrEmpty(flag) && flag != "S")
                {
                    break;
                }
                var arg = ReadArg(reader);
                if (arg != null)
                {
                    args.Add(arg);
                }
            }
        }

        private static string ConvertToEn(string text)
        {
            if (text == null)
            {
                return string.Empty;
            }
            const string ch = "。；，？！、“”‘’（）—：";//中文字符
            const string en = @".;,?!\""""''()-:";//英文字符
            var c = text.ToCharArray();
            for (var i = 0; i < c.Length; i++)
            {
                var n = ch.IndexOf(c[i]);
                if (n != -1)
                {
                    c[i] = en[n];
                }
            }
            return new string(c);
        }

        private static UfxFunctionArg ReadArg(IExcelDataReader reader)
        {
            if (string.IsNullOrEmpty(reader.GetString(C)))
            {
                return null;
            }
            var arg = new UfxFunctionArg();
            arg.Name = reader.GetString(C);
            arg.Type = reader.GetString(D);
            arg.Description = reader.GetString(E);
            arg.Required = reader.GetString(F) == "Y";
            arg.Remark = reader.GetString(G);
            if (arg.Remark != null)
            {
                arg.Remark = arg.Remark
                    .Replace('\n', ';')
                    .Replace("\r", string.Empty)
                    .Replace(" ", string.Empty);
                arg.Remark = ConvertToEn(arg.Remark);
            }
            return arg;
        }

        private static List<UfxFunction> ParseApi(IExcelDataReader reader)
        {
            const int functionFlagColumn = 1;
            var functions = new List<UfxFunction>();
            while (reader.Read())
            {
                var flag = reader.GetString(functionFlagColumn);
                if (flag != "功能号" && flag != "消息类型")
                {
                    continue;
                }

                functions.Add(ParseFunction(reader));
            }

            return functions;
        }

        private static List<DataDict> ParseDataDict(IExcelDataReader reader)
        {
            //跳过表头
            reader.Read();
            reader.Read();
            var list = new List<DataDict>();
            DataDict dict = null;
            while (reader.Read())
            {
                var flag = reader.GetValue(B)?.ToString();
                if (!string.IsNullOrEmpty(flag))
                {
                    dict = new DataDict {
                        Key = flag,
                        Name = reader.GetString(C),
                        Description = ConvertToEn(reader.GetString(D))
                    };
                    list.Add(dict);
                }
                else
                {
                    if (!string.IsNullOrEmpty(reader.GetString(C)))
                    {
                        dict?.Items.Add(new DataDictItem {
                            Value = reader.GetString(C),
                            Description = ConvertToEn(reader.GetString(D))
                        });
                    }
                }
            }
            return list;
        }

        private static List<ErrorInfo> ParseError(IExcelDataReader reader)
        {
            //跳过表头
            reader.Read();
            reader.Read();
            var list = new List<ErrorInfo>();
            while (reader.Read())
            {
                var flag = reader.GetValue(B)?.ToString();
                if (string.IsNullOrEmpty(flag))
                { continue; }
                var info = new ErrorInfo {
                    Code = int.Parse(flag),
                    Message = reader.GetString(C),
                    Remark = reader.GetString(D) ?? string.Empty
                };
                list.Add(info);
            }
            return list;
        }

        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var functions = new List<UfxFunction>();
            List<DataDict> dataDict = null;
            List<ErrorInfo> error = null;
            using var stream = File.Open("UFX20190131A.xlsx", FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            while (reader.NextResult())
            {
                switch (reader.Name)
                {
                    case "功能接口":
                    case "消息推送":
                        functions.AddRange(ParseApi(reader));
                        break;
                    case "数据词典":
                        dataDict = ParseDataDict(reader);
                        break;
                    case "标准错误定义":
                        error = ParseError(reader);
                        break;
                }
            }

            File.WriteAllText("functions.json", JsonConvert.SerializeObject(functions, Formatting.Indented));
            File.WriteAllText("dict.json", JsonConvert.SerializeObject(dataDict, Formatting.Indented));
            File.WriteAllText("error.json", JsonConvert.SerializeObject(error, Formatting.Indented));
            Console.WriteLine("Hello World!");
        }
    }
}
