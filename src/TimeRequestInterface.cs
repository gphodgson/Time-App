using System.Net.Http;
using System.Threading.Tasks;

namespace TimeApp.src
{
    public interface TimeRequestInterface
    {
        string postBodyJson { get; }
        string URIPath { get; }
        string RequestURI { get; }

        Task<TimeResponse> sendRequest(HttpClient http);
    }
}
