using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         /*
        GENERATE COMMANDS
         */

        /*
        The generate method instructs the coin daemon to immediately mine
        the indicated number of blocks. This function can only be used in
        the regtest mode (for testing purposes).
        :param numblocks: (numeric) the desired number of blocks to generate
        :return: blockhashes  JSON string) hashes of blocks generated
         */
        public string Generate(WebRequestPostExample httpInstance, int num_blocks)
        {
            string json = httpInstance.CreateJsonRequest("generate","[" + num_blocks.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
        
        /*
        The getgenerate method returns a boolean value indicating
        the server's mining status.
        :return: true/false (boolean) indicates whether the server
            is set to generate coins
         */
        public string GetGenerate(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getgenerate","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The setgenerate method allows the user to set the generate property
        in the coin daemon to true or false, thus turning generation
        (mining/staking) on or off.
        :param generate: (boolean, required) set to true to turn on
            generation; set to off to turn off generation
        :param genproclimit: (numeric, optional) set the processor limit
            for when generation is on; use value "-1" for unlimited
        :return:JSON string
         */
        public string SetGenerate(WebRequestPostExample httpInstance, Boolean generate, int genproclimit)
        {
            string json = httpInstance.CreateJsonRequest("setgenerate","[" + generate.ToString().ToLower() +  "," + genproclimit.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}