using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         /*
        GENERATE COMMANDS
         */

        public string Generate(WebRequestPostExample httpInstance, int num_blocks)
        {
            string json = httpInstance.CreateJsonRequest("generate","[" + num_blocks.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
        

        public string GetGenerate(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getgenerate","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string SetGenerate(WebRequestPostExample httpInstance, Boolean generate, int genproclimit)
        {
            string json = httpInstance.CreateJsonRequest("setgenerate","[" + generate.ToString().ToLower() +  "," + genproclimit.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}