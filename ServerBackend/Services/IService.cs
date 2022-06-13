using ServerBackend.Responses;

namespace ServerBackend.Services
{
    public interface IService
    {
        public IResponse execute(Object o);
    }
}
