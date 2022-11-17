namespace Library_WebAPI.Models
{
    public class ServiceResponse<T>
    { 
        public T? Data { get; set; }
        public string Message { get; internal set; }
    }
}
