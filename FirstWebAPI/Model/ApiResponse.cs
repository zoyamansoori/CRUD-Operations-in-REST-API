namespace ElectronixWebAPI.Model
{
    public class ApiResponse
    {
        public string Code { get; set; }    
        public string Message { get; set; } 
        public object? ResponseData { get; set; }   
        public ApiResponse() { }
    }

    public enum ResponseType
    {
        Success, 
        NotFound, 
        Failure
    }
}
