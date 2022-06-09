namespace ServerBackend.Responses
{
    public class InsertResponse : IResponse
    {
        public string message { get; set; }

        public InsertResponse(string message)
        {
            this.message = message;
        }
    }
}
