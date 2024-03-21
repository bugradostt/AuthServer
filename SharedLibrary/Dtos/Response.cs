namespace SharedLibrary.Dtos
{
    public class Response<T> where T : class
    {
        public T Data { get; private set; }

        public int StatusCode { get; private set; }

        public ErrorDto Error { get; set; }

        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> 
            {
                Data  = data,
                StatusCode = statusCode
            };

        }
    }
}