using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         /*
        UTIL COMMANDS
         */

        public string CreateMultiSig(WebRequestPostExample httpInstance, int number_required, List<String> keys)
        {
            String key_list = "[";
                foreach(var key_individual in keys)
                    {
                        key_list = key_list + "\"" + key_individual + "\"" + ",";
                    }
                if(key_list.Length > 1)
                    {
                        key_list = key_list.Substring(0, (key_list.Length - 1 ) );
                    }

                key_list = key_list + "]";

                    string json = httpInstance.CreateJsonRequest("createmultisig","[" + number_required.ToString() + "," + key_list + "]" );
                    string result = CallHttpRequest(json);
                    return result;
        }

        public string DecodeCCopret(WebRequestPostExample httpInstance,string script_pub_key)
        {
            string json = httpInstance.CreateJsonRequest("decodeccopret","[" + "\"" + script_pub_key + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string EstimateFee(WebRequestPostExample httpInstance, int num_blocks)
        {
            string json = httpInstance.CreateJsonRequest("estimatefee","["  + num_blocks.ToString()  +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string EstimatePriority(WebRequestPostExample httpInstance, int num_blocks)
        {
            string json = httpInstance.CreateJsonRequest("estimatepriority","["  + num_blocks.ToString()  +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string InvalidateBlock(WebRequestPostExample httpInstance, string block_hash)
        {
            string json = httpInstance.CreateJsonRequest("invalidateblock","["  +  "\"" + block_hash + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

         public string ReconsiderBlock(WebRequestPostExample httpInstance, string block_hash)
        {
            string json = httpInstance.CreateJsonRequest("reconsiderblock","["  +  "\"" + block_hash + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string TxNotarizeConfirmed(WebRequestPostExample httpInstance, string tx_id)
        {
            string json = httpInstance.CreateJsonRequest("txnotarizedconfirmed","["  +  "\"" + tx_id + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string ValidateAddress(WebRequestPostExample httpInstance, string address)
        {
            string json = httpInstance.CreateJsonRequest("validateaddress","["  +  "\"" + address + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string VerifyMessage(WebRequestPostExample httpInstance, string address, string signature, string message)
        {
            string json = httpInstance.CreateJsonRequest("verifymessage","["  +  "\"" + address + "\"" + "," + "\"" + signature + "\"" + "," + "\"" + message + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ValidateAddress(WebRequestPostExample httpInstance, string address)
        {
            string json = httpInstance.CreateJsonRequest("z_validateaddress","["  +  "\"" + address + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }


    }
}