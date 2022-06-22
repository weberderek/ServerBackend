using ServerBackend.Models;

namespace ServerBackend.DAOs
{
    public interface IResultDAO
    {
        List<Result> selectAllResults();
    }
}
