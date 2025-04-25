using Core.CustomExceptions.ExceptionCodes;
using System.Runtime.Serialization;

namespace Core.CustomExceptions
{
    public class CustomExceptionBase : Exception
    {
        public int ErrorCode { get; set; }

        public CustomExceptionBase(CustomExceptionCodes code,string? message) : base(message)
        {
            ErrorCode = (int)code;
        }

        public CustomExceptionBase(CustomExceptionCodes code, string? message, Exception? innerException) : base(message, innerException)
        {
            ErrorCode = (int)code;
        }
    }
}
