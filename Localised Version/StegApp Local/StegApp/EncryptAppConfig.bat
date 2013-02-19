
copy App.Config App.Config.original
rename App.config web.config
aspnet_regiis -pef connectionStrings . -prov DataProtectionConfigurationProvider
aspnet_regiis -pef secureAppSettings . -prov DataProtectionConfigurationProvider
rename web.config App.config