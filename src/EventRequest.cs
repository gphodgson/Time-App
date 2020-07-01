using System;

namespace TimeApp.src
{
    public class EventRequest : TimeRequest
    {
        public EventRequest() 
        {
            string time = DateTime.Now.ToString("h:mm:ss tt ");
            string date = DateTime.Now.ToString("ddd, MMM dd");

            postBodyJson = string.Format("{{\"game\": \"TIMEAPP\", \"event\": \"TIME\", \"data\":{{\"frame\": {{\"time-text\": \"{0} \", \"date-text\": \"{1}\"}}}}}}", time, date);
            URIPath = "/game_event";

        }

    }
}
