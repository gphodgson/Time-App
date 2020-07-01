namespace TimeApp.src
{
    public class EventSetupRequest : TimeRequest
    {
        public EventSetupRequest() 
        {
            postBodyJson = "\"game\": \"TIMEAPP\",\"event\": \"TIME\",\"value_optional\": true,\"handlers\": [{\"device-type\": \"screened\",\"mode\": \"screen\",\"zone\": \"one\",\"datas\": [{\"lines\": [{\"has-text\": true,\"prefix\": \"Time: \",\"context-frame-key\": \"time-text\",\"bold\": true,\"wrap\": 1},{\"has-text\": true,\"prefix\": \"Date: \",\"context-frame-key\": \"date-text\"}]}]}]}";
            URIPath = "/bind_game_event";
        }

    }
}
