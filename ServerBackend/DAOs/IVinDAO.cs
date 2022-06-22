using ServerBackend.Models;

namespace ServerBackend.DAOs
{
    public interface IVinDAO
    {
        List<Vin> GetVins();
    }
}
