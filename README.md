TwilioDotConfig
===============


Web/App .config able extensions for the Twilio .Net API

Twilio .Confing is a extension to the standard twiliosharp .net object that allows configuration via the web.config/app.config file.
This makes it esspecially easy to go from dev to production becasue you can leave the config files configured correctly. 

Also the project contiains a setting to allow Real .net exceptions to be thrown if the RestException property is not null

Using:
======

To create a configured Twilio Client you would do:
```
    var client = new TwilioDotConfig.TwilioDotConfigClient();
```    
With the standard Twilio client you would need to specify the account and credientials Every time you create the client
For exmaple:
```
    var client = new Twilio.TwilioRestClient("AccountSId", "Authtoken", "AccountResourceSid");
    client.ThrowExceptions = true; // if you want real exceptions to be thrown
```    

Setting up the configuration file:
----------------------------------

Setup you webconfig/appconfig:
Here is a minimal config file setup:
```
<configuration>
  <configSections>
      <section name="TwilioDotConfig" type="TwilioDotConfig.TwilioDotConfigSection"/>
  </configSections>
    <TwilioDotConfig accountSid="accountSid" authToken="authToken" accountResourceSid="accountResourceSid" TwilioBaseURL="https://api.twilio.com/" >
    </TwilioDotConfig>
</configuration>
```

Note: By default TwilioBaseURL="https://api.twilio.com/"  however it can be usefull to change it when you want to use a local emulator such 
as [ mbadler / TwilioEmulator](https://github.com/mbadler/TwilioEmulator). 
