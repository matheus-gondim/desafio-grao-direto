namespace GrainRestaurants.Core.Exceptions
{
    [System.Serializable]
    public class BadRequestException : System.Exception
    {
        public BadRequestException() : base("Bad Request Exception")
        { }
        public BadRequestException(string message) : base(message) { }
        public BadRequestException(string message, System.Exception inner) : base(message, inner) { }

        protected BadRequestException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}