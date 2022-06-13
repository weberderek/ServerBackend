using ServerBackend.DAOs;
using ServerBackend.Models;
using ServerBackend.Responses;

namespace ServerBackend.Services
{
    internal class GetProblemService : IService
    {
        private static GetProblemService _instance;

        public static GetProblemService Instance()
        {
            if( _instance == null )
                _instance = new GetProblemService();
            return _instance;
        }
        public IResponse execute(Object o)
        {
            IProblemDAO dao = ProblemDAOSQL.Instance();
            return new GetProblemResponse(dao.selectAllProblems());
        }
    }
}
