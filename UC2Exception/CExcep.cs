using System;
using System.Collections.Generic;
using System.Text;

namespace UC2Exception
{
    public class CExcep : Exception
    {
        public enum ExceptionType
        {
            null_message,
            empty_message,
        }
        private ExceptionType type;
        public CExcep(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
