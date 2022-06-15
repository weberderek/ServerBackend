using Microsoft.AspNetCore.Mvc;
using ServerBackend.Models;
using ServerBackend.Responses;
using ServerBackend.Services;

namespace ServerBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProblemController : ControllerBase
    {
        [HttpGet(Name = "GetProblem")]
        public IResponse Get()
        {
            return GetProblemService.Instance().execute(null);
        }

        [HttpPost(Name = "PostProblem")]
        public IResponse Post(Problem problem)
        {
            return InsertProblemService.Instance().execute(problem);
        }
    }
}
