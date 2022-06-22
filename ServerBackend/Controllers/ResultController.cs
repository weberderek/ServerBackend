using Microsoft.AspNetCore.Mvc;
using ServerBackend.Responses;
using ServerBackend.Services;

namespace ServerBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResultController : ControllerBase
    {
        [HttpGet(Name = "getResult")]
        public IResponse Get()
        {
            return GetResultService.Instance().execute(null);
        }
    }
}
