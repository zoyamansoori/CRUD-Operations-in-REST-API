namespace ElectronixWebAPI.Model
{
    public class ResponseHandler
    {
        public static ApiResponse GetExceptionResponse(Exception ex)
        {
            ApiResponse response = new ApiResponse();
            response.Code = "1";                            //1 is for failure
            response.ResponseData = ex.Message; 
            return response;
        }
        public static ApiResponse GetAppResponse(ResponseType type, object? contract) 
        {
            ApiResponse response;
            response = new ApiResponse { ResponseData = contract };
            switch (type)
            {
                case ResponseType.Success:
                    response.Code = "0";                    //0 is for success
                    response.Message = "Success";
                    break;

                case ResponseType.NotFound:
                    response.Code = "2";                    //2 is for NotFound
                    response.Message = "No record available";
                    break;
            }
            return response;
        }
    }
}
