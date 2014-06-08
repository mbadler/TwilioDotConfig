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
            : base(config.accountSid,config. authToken,config.accountResourceSid==""?config.accountSid:config.accountResourceSid)
        {
           
            if (config.TwilioBaseURL != "" && config.UseTwilioProductionURL != true)
            {
                // setup the base url using reflection
                Type type = typeof (TwilioRestClient) ;
                var b = (RestClient)type.GetField("_client", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this);

                b.BaseUrl = config.TwilioBaseURL;
            }

            ThrowExceptions = config.ThrowExceptions;
        }

        public override T Execute<T>(RestRequest request)
        {
            var a = base.Execute<T>(request);
            if (ThrowExceptions && ((TwilioBase)(object)a).RestException != null)
            {
                var restEx = ((TwilioBase)(object)a).RestException;
                throw new TwilioRestException(restEx.Message, restEx.Code, restEx.MoreInfo, restEx.Status);
            }
            return a;
        }

        public bool ThrowExceptions { get; set; }
    }
}
