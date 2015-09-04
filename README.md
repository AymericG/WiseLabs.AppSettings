# WiseLabs.AppSettings
Enables ASP.NET Membership provider and ELMAH to read connection string from AppSettings

## Installation

Install the nuget package:
> Install-Package WiseLabs.AppSettings


Edit your Asp.net Membership provider configuration by changing the type attribute and adding a appSettingsKey
> <add   
>   name="AspNetSqlMembershipProvider"   
>   type="WiseLabs.AppSettings.AppSettingsMembershipProvider"   
>   appSettingsKey="ConnectionStrings.Main"  

If you have ELMAH installed with SQL logs enabled, change the definition like so:

> <errorLog 
>      type="WiseLabs.AppSettings.AppSettingsSqlErrorLog, WiseLabs.AppSettings"   
>      connectionStringName="WeekPlanConnectionString"   
>      appSettingsKey="ConnectionStrings.Main"

IMPORTANT: You need to have a valid connection string in the <connectionStrings> section even though it won't be used.

## Documentation
- [Creating and publishing a package](https://docs.nuget.org/create/creating-and-publishing-a-package)

