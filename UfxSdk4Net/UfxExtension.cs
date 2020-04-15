using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using hundsun.t2sdk;

namespace QuantBox.XApi
{
    /// <summary>
    /// 功能调用包
    /// </summary>
    public interface IUfxFunctionCall
    {
        /// <summary>
        /// 功能号
        /// </summary>
        int FunctionId { get; }
        /// <summary>
        /// 创建功能请求数据包
        /// </summary>
        /// <returns></returns>
        CT2Packer Pack();

    }

    /// <summary>
    /// 数据包扩展函数
    /// </summary>
    public static class UfxUnPackerExtension
    {
        /// <summary>
        /// 从数据包中获取错误代码
        /// </summary>
        /// <param name="packer"></param>
        /// <returns></returns>
        public static int GetErrCode(this CT2UnPacker packer)
        {
            return packer.GetInt("ErrorCode");
        }

        /// <summary>
        /// 从数据包中获取错误细节
        /// </summary>
        /// <param name="packer"></param>
        /// <returns></returns>
        public static string GetMsgDetail(this CT2UnPacker packer)
        {
            return packer.GetStr("MsgDetail");
        }

        /// <summary>
        /// 从数据包中获取错误信息
        /// </summary>
        /// <param name="packer"></param>
        /// <returns></returns>
        public static string GetErrMsg(this CT2UnPacker packer)
        {
            return packer.GetStr("ErrorMsg");
        }

        /// <summary>
        /// 获取数据包的内容
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static string GetPackContent(this CT2UnPacker result)
        {
            var lines = new StringBuilder();
            for (var i = 0; i < result.GetDatasetCount(); i++)
            {
                result.SetCurrentDatasetByIndex(i);
                var rows = result.GetRowCount();
                var cols = result.GetColCount();
                lines.AppendLine($"DataSet {i}, {rows}, {cols}");
                result.First();
                while (result.IsEOF() == 0)
                {
                    for (var col = 0; col < cols; col++)
                    {
                        var name = result.GetColName(col);
                        var type = result.GetColType(col);
                        if (type != 'R')
                        {
                            lines.Append($"{name}=[{result.GetStrByIndex(col)}]");
                        }
                        else
                        {
                            unsafe
                            {
                                var colLength = 0;
                                var colValue = result.GetRawByIndex(i, &colLength);
                                lines.Append($"{name}=[{Marshal.PtrToStringAuto(new IntPtr(colValue))}]");
                            }
                        }
                        lines.Append(",");
                    }
                    lines.Append(Environment.NewLine);
                    result.Next();
                }
            }
            return lines.ToString();
        }
    }
}
