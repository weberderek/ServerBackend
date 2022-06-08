using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;

namespace ServerBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProblemController : ControllerBase
    {
        [HttpGet(Name = "GetProblem")]
        public string Get()
        {
            return "problems";
        }

        [HttpPost(Name = "PostProblem")]
        public string Post(string request)
        {
            return request;
        }
    }
}
