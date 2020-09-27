<!--Category:Powershell--> 
 <p align="right">
    <a href="https://www.powershellgallery.com/packages/ProductivityTools.PSDbUp/"><img src="Images/Header/Powershell_border_40px.png" /></a>
    <a href="http://productivitytools.tech/psdbup/"><img src="Images/Header/ProductivityTools_green_40px_2.png" /><a> 
    <a href="https://github.com/pwujczyk/ProductivityTools.PSDbUp"><img src="Images/Header/Github_border_40px.png" /></a>
</p>
<p align="center">
    <a href="http://productivitytools.tech/">
        <img src="Images/Header/LogoTitle_green_500px.png" />
    </a>
</p>

# PowerShell Master Configuration

Module allows to store configuration in one single file.

To use it you need to have setup environment variable **MasterConfigurationPath** to the directory where you would like to store configuration.

![Environment Variable](Images\MasterConfigurationEnvironmentVariable.png)

In given directory you need to have json configuration file

![Configuration file](Images\MasterConfigurationFile.png)

Configuration should be in simple json format with configuration in key-value pair.

```
{
  "Login": "14561018",
  "Password":"p@ssword",
  "NugetApiKey":"oy2kzj5fdsafdsafdfwefdgrehrthwywtfesgfdwjmvjezikvbee6be3u5m"
}
```

To use the module call ```Get-MasterConfiguration``` with key.

![GetMasterConfiguration](Images\GetMaterConfigurationLogin.png)

If you would like to see all config values, use ```-All``` switch.

![GetMasterConfiguration](Images\GetMaterConfigurationAll.png)



Module is based on [MasterConfiguration](https://www.nuget.org/packages/ProductivityTools.MasterConfiguration/) NuGet package.

