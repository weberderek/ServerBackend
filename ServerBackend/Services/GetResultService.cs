using ServerBackend.DAOs;
using ServerBackend.Responses;

namespace ServerBackend.Services
{
    internal class GetResultService : IService
    {
        private static GetResultService _instance;
        public static GetResultService Instance()
        {
            if(_instance == null)
                _instance = new GetResultService();
            return _instance;
        }
        public IResponse execute(object o)
        {
            IResultDAO dao = ResultDAOAccess.Instance();
            return new GetResultResponse(dao.selectAllResults());
        }
    }
}
