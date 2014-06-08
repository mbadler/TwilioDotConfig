using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwilioDotConfig
{

    [Serializable]
    public class TwilioRestException : Exception
    {
        /// <summary>
        /// The HTTP status code for the exception.
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// (Conditional) The URL of Twilio's documentation for the error code.
        /// </summary>
        public string MoreInfo { get; set; }
        /// <summary>
        /// (Conditional) An error code to find help for the exception.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// A more descriptive message regarding the exception.
        /// </summary>
        public string Message { get; set; }

        public TwilioRestException(string Message,string Code,string MoreInfo,string Status) 
        {
            this.Message = Message;
            this.MoreInfo = MoreInfo;
            this.Status = Status;
            this.Code = Code;
        }

    }
    
}
