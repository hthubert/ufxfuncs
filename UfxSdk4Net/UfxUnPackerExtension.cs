using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using hundsun.t2sdk;

namespace QuantBox.XApi
{
    public static class UfxUnPackerExtension
    {
        public static int GetErrCode(this CT2UnPacker packer)
        {
            return packer.GetInt("ErrorCode");
        }

        public static string GetMsgDetail(this CT2UnPacker packer)
        {
            return packer.GetStr("MsgDetail");
        }

        public static string GetErrMsg(this CT2UnPacker packer)
        {
            return packer.GetStr("ErrorMsg");
        }

        public static string GetPackContent(this CT2UnPacker result)
        {
            var lines = new StringBuilder();
            for (var i = 0; i < result.GetDatasetCount(); i++) {
                result.SetCurrentDatasetByIndex(i);
                var rows = result.GetRowCount();
                var cols = result.GetColCount();
                lines.AppendLine($"DataSet {i}, {rows}, {cols}");
                while (result.IsEOF() == 0) {
                    for (var col = 0; col < cols; col++) {
                        var name = result.GetColName(col);
                        var type = result.GetColType(col);
                        if (type != 'R') {
                            lines.Append($"{name}=[{result.GetStrByIndex(col)}]");
                        }
                        else {
                            unsafe {
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
