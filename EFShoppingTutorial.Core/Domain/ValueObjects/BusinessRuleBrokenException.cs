using System.Runtime.Serialization;

namespace EFShoppingTutorial.Core.Domain.ValueObjects
{
    [Serializable]
    internal class BusinessRuleBrokenException : Exception
    {
        public BusinessRuleBrokenException()
        {
        }

        public BusinessRuleBrokenException(string? message) : base(message)
        {
        }

        public BusinessRuleBrokenException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BusinessRuleBrokenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}