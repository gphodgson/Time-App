using System.Net.Http;
using System.Threading.Tasks;

namespace TimeApp.src
{
    public abstract class TimeRequest : TimeRequestInterface
    {
        public string postBodyJson { get; protected set; }
        public string URIPath { get; protected set; }
        public string RequestURI { get; protected set; }


        public TimeRequest() 
        {
            RequestURI = Helper.getRequestURI() + URIPath;
        }

        public async Task<TimeResponse> sendRequest(HttpClient http)
        {
            StringContent postBody = new StringContent(this.postBodyJson, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await http.PostAsync(Helper.getRequestURI() + URIPath, postBody); ;

            return new TimeResponse(await response.Content.ReadAsStringAsync(), "200", this);
        }
    }
}
