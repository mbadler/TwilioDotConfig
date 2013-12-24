using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twilio;
using RestSharp;
using System.Reflection;

namespace TwilioDotConfig
{
    public class TwilioDotConfigClient:TwilioRestClient
    {

        static TwilioDotConfigSection config =
        (TwilioDotConfigSection)System.Configuration.ConfigurationManager.GetSection(
        "TwilioDotNet");

        public TwilioDotConfigClient(string accountSid, string authToken) : this(accountSid, authToken, accountSid) { }

        public TwilioDotConfigClient(string accountSid, string authToken, string accountResourceSid)
            : base(accountSid, authToken, accountResourceSid)
        {

        }

        public TwilioDotConfigClient()
            : base(config.accountSid,config. authToken,config.accountResourceSid)
        {
            if (config.TwilioBaseURL != "")
            {
                // setup the base url using reflection
                Type type = typeof (TwilioRestClient) ;
                var b = (RestClient)type.GetField("_client", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this);
                b.BaseUrl = config.TwilioBaseURL;
            }
        }
    }
}
