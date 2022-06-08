using ServerBackend.DAOs;
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
        public IResponse execute()
        {
            IProblemDAO dao = ProblemDAOSQL.Instance();
            return new GetProblemResponse(dao.selectAllProblems());
        }
    }
}
