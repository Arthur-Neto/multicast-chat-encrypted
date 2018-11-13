using System;
using System.Net;
using System.Web.Http;

namespace Chat.WebAPI.Controllers
{
    public class ApiControllerBase : ApiController
    {

        protected IHttpActionResult HandleCallback<TSuccess>(Func<TSuccess> func)
        {
            try
            {
                return Ok(func());
            }
            catch (Exception e)
            {
                return HandleFailure(e);
            }
        }

        protected IHttpActionResult HandleFailure<T>(T exceptionToHandle) where T : Exception
        {
            return exceptionToHandle is Exception ?
                Content(HttpStatusCode.BadRequest, new Exception()) :
                Content(HttpStatusCode.InternalServerError, new Exception());
        }
    }
}