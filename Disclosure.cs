using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
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