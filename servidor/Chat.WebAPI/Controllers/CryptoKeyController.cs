using Chat.Infraestrutura;
using Chat.WebAPI.Filters;
using System.Web.Http;

namespace Chat.WebAPI.Controllers
{
    [RoutePrefix("api/cryptokey")]
    public class CryptoKeyController : ApiControllerBase
    {
        [HttpGet]
        [RequireHttps]
        public IHttpActionResult BuscarChaveCriptografia()
        {
            return HandleCallback(() => ChaveCriptografia.CHAVE);
        }
    }
}
