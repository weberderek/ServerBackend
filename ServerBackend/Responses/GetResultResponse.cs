using ServerBackend.Models;

namespace ServerBackend.Responses
{
    internal class GetResultResponse : IResponse
    {
        public List<Result> results { get; set; }
        public GetResultResponse(List<Result> results)
        {
            this.results = results;
        }

        override public string ToString()
        {
            string result = "";
            for (int i = 0; i < results.Count; i++)
            {
                result += results[i].ToString();
                result += '\n';
            }
            return result;
        }
    }
}
