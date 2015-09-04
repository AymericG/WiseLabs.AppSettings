using System.Collections.Specialized;
using System.Configuration;
using System.Reflection;
using System.Web.Security;

namespace WiseLabs.AppSettings
{
    public class AppSettingsMembershipProvider : SqlMembershipProvider
    {
        public override void Initialize(string name, NameValueCollection config)
        {
            base.Initialize(name, config);
            
            // Update the private connection string field in the base class.  
            string connectionString = ConfigurationManager.AppSettings[config["appSettingsKey"]];

            // Set private property of Membership provider.  
            FieldInfo connectionStringField = GetType().BaseType.GetField("_sqlConnectionString", BindingFlags.Instance | BindingFlags.NonPublic);

            connectionStringField.SetValue(this, connectionString);
        }
    }
}
