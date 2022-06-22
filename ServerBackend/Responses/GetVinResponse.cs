using ServerBackend.Models;

namespace ServerBackend.Responses
{
    internal class GetVinResponse : IResponse
    {
        public List<Vin> vins { get; set; }
        public GetVinResponse(List<Vin> vins)
        {
            this.vins = vins;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
