﻿using System.Text;

namespace ExcelDataReader.Core.BinaryFormat
{
    internal sealed class XlsBiffCodeName : XlsBiffRecord
    {
        // private readonly IXlsString _xlsString;
        private readonly XlsUnicodeString _xlsString;

        internal XlsBiffCodeName(byte[] bytes)
            : base(bytes)
        {
            // BIFF8 only
            _xlsString = new XlsUnicodeString(bytes, ContentOffset);
        }

        public string GetValue(Encoding encoding)
        {
            return _xlsString.GetValue(encoding);
        }
    }
}
