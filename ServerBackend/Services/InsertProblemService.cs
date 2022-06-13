using ServerBackend.Responses;
using ServerBackend.DAOs;
using ServerBackend.Models;

namespace ServerBackend.Services
{
    internal class InsertProblemService : IService
    {
        private static InsertProblemService _instance;

        public static InsertProblemService Instance()
        {
            if (_instance == null)
                _instance = new InsertProblemService();
            return _instance;
        }
        public IResponse execute(Object o)
        {
            IProblemDAO dao = ProblemDAOSQL.Instance();
            return new InsertResponse(dao.insertProblem((Problem) o));
        }
    }
}
