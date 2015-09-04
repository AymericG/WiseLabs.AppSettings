using System.Collections;
using System.Configuration;
using Elmah;

namespace WiseLabs.AppSettings
{
    public class AppSettingsSqlErrorLog : SqlErrorLog
    {
        protected string appSettingsKey;
        public AppSettingsSqlErrorLog(IDictionary config)
            : base(config)
        {
            appSettingsKey = (string)config["appSettingsKey"];
        }

        public override string ConnectionString
        {
            get { return ConfigurationManager.AppSettings[appSettingsKey]; }
        }
    }
}
