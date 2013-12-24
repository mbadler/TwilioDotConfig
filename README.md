TwilioDotConfig
===============

Web/App .config able extensions for the Twilio .Net API

Twilio .Confing is a extension to the standard twiliosharp .net object that allows configuration via the web.config/app.config file.
This makes it esspecially easy to go from dev to production becasue you can leave the config files configured correctly. 


Using:
======

To create a configured Twilio Client you would do:
    var client = new TwilioDotConfig.TwilioDotConfigClient();
    
With the standard Twilio client you would need to specify the account and credientials Every time you create the client
For exmaple:
    var client = new Twilio.TwilioRestClient("AccountSId", "Authtoken", "AccountResourceSid");
    

Setting up the configuration file:
----------------------------------

Setup you webconfig/appconfig:
Here is a minimal config file setup:
```
<configuration>
  <configSections>
      <section name="TwilioDotNet" type="TwilioDotConfig.TwilioDotConfigSection"/>
  </configSections>
    <TwilioDotNet accountSid="accountSid" authToken="authToken" accountResourceSid="accountResourceSid" TwilioBaseURL="https://api.twilio.com/" >
    </TwilioDotNet>
</configuration>
```

Note: By default TwilioBaseURL="https://api.twilio.com/"  however it can be usefull to change it when you want to use a local emulator such 
as [ mbadler / TwilioEmulator](https://github.com/mbadler/TwilioEmulator). 
