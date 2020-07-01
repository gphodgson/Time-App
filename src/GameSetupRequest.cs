namespace TimeApp.src
{
    public class GameSetupRequest : TimeRequest
    {
        public GameSetupRequest() 
        {
            postBodyJson = "{\"game\":\"TIMEAPP\",\"game_display_name\": \"Time Display\",\"developer\": \"Geoffrey Hodgson\"}";
            URIPath = "/game_metadata";
        }

    }
}
