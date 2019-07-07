using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
        /*
        JUMBLR COMMANDS
         */

        public string jumblr_deposit(WebRequestPostExample httpInstance, string deposit_address)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_deposit","[" + "\"" + deposit_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string jumblr_pause(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_pause","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string jumblr_resume(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_resume","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string jumblr_secret(WebRequestPostExample httpInstance, String secret_address)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_secret","[" + "\"" + secret_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}