using System;
using System.Runtime.Serialization;

namespace Markum.Cloud.Libraries.Mail
{
    [Serializable]
    public class MEException : Exception
    {
        // MailEnable.ERRORCODES
        private int? error;

        public override string Message
        {
            get
            {
                string message = base.Message;
                if (error.HasValue)
                {
                    string errorMessage = error.ToString();
                    return message + '\n' + errorMessage;
                }
                return message;
            }
        }

        public virtual int? Error
        {
            get
            {
                return error;
            }
        }

        public MEException()
        {

        }

        public MEException(string message)
            : base(message)
        {

        }

        public MEException(string message, Exception inner)
            : base(message, inner)
        {

        }

        protected MEException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

        public MEException(int errorcode)
        {
            error = errorcode;
        }

        public MEException(string message, int errorcode)
            : base(message)
        {
            error = errorcode;
        }

        public MEException(string message, int errorcode, Exception inner)
            : base(message, inner)
        {
            error = errorcode;
        }
    }
}