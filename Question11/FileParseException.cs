using System;
using System.Collections.Generic;
using System.Text;

namespace Question11
{
    class FileParseException : Exception
    {
        public FileParseException(string message, string fileName, int line) : base(message)
        {
        }
    }
}
