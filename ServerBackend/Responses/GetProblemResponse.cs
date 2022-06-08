using ServerBackend.Models;

namespace ServerBackend.Responses
{
    internal class GetProblemResponse : IResponse
    {
        public List<Problem> problems { get; set; }
        public GetProblemResponse(List<Problem> problems)
        {
            this.problems = problems;
        }

        override public string ToString()
        {
            string result = "";
            for (int i = 0; i < problems.Count; i++)
            {
                result += problems[i].ToString();
                result += '\n';
            }
            return result;
        }
    }
}
