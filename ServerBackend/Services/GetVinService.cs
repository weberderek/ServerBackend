using ServerBackend.DAOs;
using ServerBackend.Responses;

namespace ServerBackend.Services
{
    internal class GetVinService : IService
    {
        private static GetVinService _instance;
        public static GetVinService Instance()
        {
            if(_instance == null)
                _instance = new GetVinService();
            return _instance;
        }
        public IResponse execute(object o)
        {
            IVinDAO dao = VinDAOSQL.Instance();
            return new GetVinResponse(dao.GetVins());
        }
    }
}
