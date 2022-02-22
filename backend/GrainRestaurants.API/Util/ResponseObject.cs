namespace GrainRestaurants.API.Util
{
    public class ResponseObject<T>
    {
        public ResponseObject(T content, string message = "Requisição realizada com sucesso.")
        {
            Content = content;
            Message = message;
        }

        public T Content { get; internal set; }

        public string Message { get; internal set; }
    }
}
