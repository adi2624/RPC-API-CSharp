using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
        
        /*
        
            CONTROL COMMANDS

         */

        
        public string GetInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Help(WebRequestPostExample httpInstance,string command)
        {
            string json = httpInstance.CreateJsonRequest("help","[" + "\"" + command + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Stop(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("stop","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        DISCLOSURE COMMANDS
         */

        public string Z_GetPaymentDisclosure(WebRequestPostExample httpInstance, string txid, string js_index, string output_index, string message)
        {
            string json = httpInstance.CreateJsonRequest("z_getpaymentdisclosure","[" + "\"" + txid + "\"" + "," + "\"" + js_index + "\"" + "," + "\"" + output_index + "\"" + "," + "\"" + message + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ValidatePaymentDisclosure(WebRequestPostExample httpInstance, string payment_disclosure)
        {
            string json = httpInstance.CreateJsonRequest("z_validatepaymentdisclosure","[" + "\"" + payment_disclosure + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}