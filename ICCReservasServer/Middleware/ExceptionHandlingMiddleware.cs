using ICCReservasServer.Middleware.Models;
using Newtonsoft.Json;
using System.Net;

namespace ICCReservasServer.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        public RequestDelegate requestDelegate;
        public ExceptionHandlingMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await requestDelegate(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }
        private static Task HandleException(HttpContext context, Exception ex)
        {
            var errorMessageObject = new Error { Message = ex.Message, Code = "GE" };
            var statusCode = (int)HttpStatusCode.InternalServerError;
            switch (ex)
            {
                case RegisteredEmailException: 
                    errorMessageObject.Code = "AUTH001";
                    statusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case UnauthorizedEmailException:
                    errorMessageObject.Code = "AUTH002";
                    statusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case FailedLoginException:
                    errorMessageObject.Code = "AUTH003";
                    statusCode = (int)HttpStatusCode.BadRequest;
                    break;
                case EmailNotFoundException:
                    errorMessageObject.Code = "AUTH004";
                    statusCode = (int)HttpStatusCode.BadRequest;
                    break;

            }

            var errorMessage = JsonConvert.SerializeObject(errorMessageObject);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            return context.Response.WriteAsync(errorMessage);
        }
    }
}
