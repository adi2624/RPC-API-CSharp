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

       
    }
}