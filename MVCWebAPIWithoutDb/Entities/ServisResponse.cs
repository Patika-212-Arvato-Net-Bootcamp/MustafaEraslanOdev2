namespace MVCWebAPIWithoutDb.Entities
{
    public class ServiceResponse<T> //Eğer responce alamazsak hata dönmemiz için.
    {
        public ServiceResponse(string errorMessage, int statusCode, T data)
        {
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
            Data = data;
        }

        public string ErrorMessage { get; set; }
        public int StatusCode { get; set; }

        public T Data { get; set; }
    }
}
