namespace MVCWebAPIWithoutDb.Entities
{
    public class ServiceResponse<T>
    {
        public ServiceResponse(string errorMessage, int statusCode, T data)
        {
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
            Data = data;
        }

        public string ErrorMessage { get; set; }
        public int StatusCode { get; set; }

        public T Data { get; set; }// ben sana data döneceğim anlamındır.   
    }
}
