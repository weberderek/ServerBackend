using ServerBackend.Responses;
using ServerBackend.DAOs;
using ServerBackend.Models;

namespace ServerBackend.Services
{
    public class InsertProblemService
    {
        private static InsertProblemService _instance;

        public static InsertProblemService Instance()
        {
            if (_instance == null)
                _instance = new InsertProblemService();
            return _instance;
        }
        public IResponse execute(Problem problem)
        {
            IProblemDAO dao = ProblemDAOSQL.Instance();
            return new InsertResponse(dao.insertProblem(problem));
        }
    }
}
