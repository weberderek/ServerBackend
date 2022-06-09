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
            return GetProblemService.Instance().execute();
        }

        [HttpPost(Name = "PostProblem")]
        public string Post(Problem problem)
        {
            return problem.ToString();
        }
    }
}
