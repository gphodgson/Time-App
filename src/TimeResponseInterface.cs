namespace TimeApp.src
{
    public interface TimeResponseInterface
    {
        string ResponseBody { get; }
        string ResponseCode { get; }
        TimeRequestInterface TimeRequest { get; }

    }
}
