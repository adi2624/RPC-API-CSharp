using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         /*
        DISCLOSURE COMMANDS
         */

        /*
        The z_getpaymentdisclosure method generates a payment disclosure
        for a given joinsplit output
        EXPERIMENTAL FEATURE: Payment disclosure is currently DISABLED.
        This call always fails.
        :param txid: (string, required)
        :param js_index: (string, required)
        :param output_index: (string, required)
        :param message: (string, optional)
        :return: "paymentdisclosure" (string) a hex data string,
            with a "zpd:" prefix
         */
        public string Z_GetPaymentDisclosure(WebRequestPostExample httpInstance, string txid, string js_index, string output_index, string message)
        {
            string json = httpInstance.CreateJsonRequest("z_getpaymentdisclosure","[" + "\"" + txid + "\"" + "," + "\"" + js_index + "\"" + "," + "\"" + output_index + "\"" + "," + "\"" + message + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_validatepaymentdisclosure method validates a payment disclosure.
        :param paymentdisclosure: (string, required) hex data string,
            with "zpd:" prefix
        :return: (currently disabled)
         */
        public string Z_ValidatePaymentDisclosure(WebRequestPostExample httpInstance, string payment_disclosure)
        {
            string json = httpInstance.CreateJsonRequest("z_validatepaymentdisclosure","[" + "\"" + payment_disclosure + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}