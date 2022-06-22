using Microsoft.AspNetCore.Mvc;
using ServerBackend.Responses;
using ServerBackend.Services;

namespace ServerBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VinController : ControllerBase
    {
        [HttpGet(Name = "GetVin")]
        public IResponse Get()
        {
            return GetVinService.Instance().execute(null);
        }

        //[HttpGet(Name = "GetVin")]
        //public IResponse Get()
        //{
        //    return GetProblemService.Instance().execute(null);
        //}
    }
}
