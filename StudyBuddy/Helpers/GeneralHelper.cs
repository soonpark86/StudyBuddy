using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace StudyBuddy.Helpers
{
    public class GeneralHelper
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["StudyBuddy"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["soonpark86"];
            string password = appConfig["dh119119"];
            string hostname = appConfig["aakhaxjufw2s5r.c5jifixvwcrz.us-east-2.rds.amazonaws.com"];
            string port = appConfig["1433"];

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}
