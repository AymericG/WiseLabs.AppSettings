# WiseLabs.AppSettings
Enables ELMAH SqlErrorLog to read connection string from AppSettings

## Installation

Install the nuget package:
> Install-Package WiseLabs.AppSettings

If you have ELMAH installed with SQL logs enabled, change the definition like so:

> <errorLog 
>      type="WiseLabs.AppSettings.AppSettingsSqlErrorLog, WiseLabs.AppSettings"   
>      connectionStringName="WeekPlanConnectionString"   
>      appSettingsKey="ConnectionStrings.Main"

IMPORTANT: You need to have a valid connection string in the <connectionStrings> section even though it won't be used.

## Documentation
- [Creating and publishing a package](https://docs.nuget.org/create/creating-and-publishing-a-package)

