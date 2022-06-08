using Microsoft.AspNetCore.Mvc;
using ServerBackend.Models;
using ServerBackend.Responses;
using ServerBackend.Services;
//using System.Web.Http;

namespace ServerBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProblemController : ControllerBase
    {
        [HttpGet(Name = "GetProblem")]
        public IResponse Get()
        {
            IResponse response = GetProblemService.Instance().execute();
            return response;
        }

        [HttpPost(Name = "PostProblem")]
        public string Post(string request)
        {
            return request;
            IModel problem = new Problem();
        }
    }
}
