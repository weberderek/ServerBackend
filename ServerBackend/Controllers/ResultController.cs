using Microsoft.AspNetCore.Mvc;

namespace ServerBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResultController : ControllerBase
    {
        [HttpGet(Name = "getResult")]
        public IResponseCookies Get()
        {
            return GetResultService.Instance().execute(null);
        }
    }
}
