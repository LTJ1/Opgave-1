using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module20
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = GetAppSetting("ip", "127.0.0.1");
            Console.WriteLine("ip adressen" + ip);
            int maxRecords = GetAppSettingGeneric("maxrecords", 100);
            Console.WriteLine("max records ", maxRecords);

        }

        static string GetAppSetting(string key, string defaultValue)
        {
            string v = System.Configuration.ConfigurationManager.AppSettings[key];
            if (v == null)
                return defaultValue;
            return v;
        }

        static T GetAppSettingGeneric<T>(string key, T defaultValue)
        {
            string v = System.Configuration.ConfigurationManager.AppSettings[key];
            if (v == null)
                return defaultValue;
            return (T)Convert.ChangeType(v, typeof(T));
        } 
    }
}
