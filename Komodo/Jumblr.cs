using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
        /*
        JUMBLR COMMANDS
         */


        /*
        The jumblr_deposit method indicates the address from which
        Jumblr should withdraw funds.
        :param depositaddress: (string, required) the address from
            which Jumblr will withdraw funds
        :return: JSON string
         */
        public string JumblrDeposit(WebRequestPostExample httpInstance, string deposit_address)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_deposit","[" + "\"" + deposit_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The jumblr_pause method instructs Jumblr to temporarily pause
        the privacy-shielding process.
        :return: JSON string
         */
        public string JumblrPause(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_pause","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The jumblr_resume method instructs Jumblr to resume
        the privacy-shielding process.
        :return: JSON string
         */
        public string JumblrResume(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_resume","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The jumblr_secret method indicates to Jumblr the final
        destination address.
        :param secretaddress: (string, required) the destination
            transparent address
        :return: JSON string
         */

        public string JumblrSecret(WebRequestPostExample httpInstance, String secret_address)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_secret","[" + "\"" + secret_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}