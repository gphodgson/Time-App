using System.IO;
using Newtonsoft.Json;

namespace TimeApp.src
{
    public static class Helper
    {
        public static string defaultCorePropsPath = "C:\\ProgramData\\SteelSeries\\SteelSeries Engine 3\\coreProps.json";

        public static void configOnOff(string _key)
        {
            System.Configuration.Configuration conf = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);

            if (conf.AppSettings.Settings[_key].Value == "true")
            {
                conf.AppSettings.Settings.Remove(_key);
                conf.AppSettings.Settings.Add(_key, "false");
            }
            else
            {
                conf.AppSettings.Settings.Remove(_key);
                conf.AppSettings.Settings.Add(_key, "true");
            }
            conf.Save(System.Configuration.ConfigurationSaveMode.Modified);
        }

        public static void configOff(string _key)
        {
            System.Configuration.Configuration conf = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            conf.AppSettings.Settings.Remove(_key);
            conf.AppSettings.Settings.Add(_key, "false");

            conf.Save(System.Configuration.ConfigurationSaveMode.Modified);
        }

        public static string getRequestURI() 
        {
            CoreProps hostPort = getCoreProps();

            return "http://" + hostPort.address;
        }

        public static CoreProps getCoreProps() 
        {
            using (StreamReader r = new StreamReader(defaultCorePropsPath)) 
            {
                string corePropsJson = r.ReadToEnd();
                CoreProps corePropsObj = JsonConvert.DeserializeObject<CoreProps>(corePropsJson);

                return corePropsObj;
            }
        }
    }
}
