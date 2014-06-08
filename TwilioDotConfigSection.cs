using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace TwilioDotConfig
{
    public class TwilioDotConfigSection:ConfigurationSection
    {
        [ConfigurationProperty("accountSid", DefaultValue = "", IsRequired = false)]
        public string accountSid
        {
            get { return (string)this["accountSid"]; }
            set { this["accountSid"] = value; }
        }

        [ConfigurationProperty("authToken", DefaultValue = "", IsRequired = false)]
        public string authToken
        {
            get { return (string)this["authToken"]; }
            set { this["authToken"] = value; }
        }

        [ConfigurationProperty("accountResourceSid", DefaultValue = "", IsRequired = false)]
        public string accountResourceSid
        {
            get { return (string)this["accountResourceSid"]; }
            set { this["accountResourceSid"] = value; }
        }

        [ConfigurationProperty("TwilioBaseURL", DefaultValue = "https://api.twilio.com/", IsRequired = false)]
        public string TwilioBaseURL
        {
            get { return (string)this["TwilioBaseURL"]; }
            set { this["TwilioURL"] = value; }
        }

        [ConfigurationProperty("UseTwilioProductionURL", DefaultValue = "false", IsRequired = false)]
        public bool UseTwilioProductionURL
        {
            get { return (bool)this["UseTwilioProductionURL"]; }
            set { this["UseTwilioProductionURL"] = value; }
        }

        [ConfigurationProperty("ThrowExceptions", DefaultValue = "false", IsRequired = false)]
        public bool ThrowExceptions
        {
            get { return (bool)this["ThrowExceptions"]; }
            set { this["ThrowExceptions"] = value; }
        }


    }
}
