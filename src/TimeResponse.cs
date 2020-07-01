namespace TimeApp.src
{
    public class TimeResponse : TimeResponseInterface
    {
        public string ResponseBody { get; }
        public string ResponseCode { get; }
        public TimeRequestInterface TimeRequest { get; }

        public TimeResponse(string responseBody, string responseCode, TimeRequestInterface timeRequest)
        {
            ResponseBody = responseBody;
            ResponseCode = responseCode;
            TimeRequest = timeRequest;
        }
    }
}