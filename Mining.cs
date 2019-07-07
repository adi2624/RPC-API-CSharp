using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         /*
        MINING COMMANDS
         */

        public string GetBlockSubsidy(WebRequestPostExample httpInstance, int height)
        {
            string json;

            if (height > 0)
                {
                    json = httpInstance.CreateJsonRequest("getblocksubsidy","[" +  height.ToString() + "]" );
                    string result = CallHttpRequest(json);
                    return result;
                }
            else
                {
                    json = httpInstance.CreateJsonRequest("getblocksubsidy","[" +  "]" );
                    string result = CallHttpRequest(json);
                    return result;
                }
        }

        public string GetBlockTemplate(WebRequestPostExample httpInstance, string mode, List<String> capabilities, string support)
        {
             String cap_list = "[";
                foreach(var cap_individual in capabilities)
                    {
                        cap_list = cap_list + "\"" + cap_individual + "\"" + ",";
                    }
                if(cap_list.Length > 1)
                    {
                        cap_list = cap_list.Substring(0, (cap_list.Length - 1 ) );
                    }

                cap_list = cap_list + "]";

                    string json = httpInstance.CreateJsonRequest("getblocktemplate","[{"  + "\"" + "mode" + "\":" + (mode != "" ?"\"" + mode : "") + "\"" + ","  + "\"" + "capabilities" + "\":" + (cap_list.Length > 0 ? cap_list :"") + ","  + "\"" + "support" + "\":" + "\"" + (support != "" ? "\"" + support : "") + "\""  +  "}]" );
                    string result = CallHttpRequest(json);
                    return result;

        }

        public string GetLocalSolps(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getlocalsolps","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetMiningInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getmininginfo","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetNetworkSolps(WebRequestPostExample httpInstance, int blocks, int height)
        {
            string json = httpInstance.CreateJsonRequest("getnetworksolps","[" + blocks.ToString() + "," + height.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
        public string PrioritiseTransaction(WebRequestPostExample httpInstance, string txid, double priority_delta, int fee_delta)
        {
            string json = httpInstance.CreateJsonRequest("prioritisetransaction","[" + "\"" + txid + "\"" + "," + priority_delta.ToString()+ "," + fee_delta.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }      

        public string SubmitBlock(WebRequestPostExample httpInstance, string hexdata, string workid)
        {
            string json = httpInstance.CreateJsonRequest("submitblock","[" + "\"" + hexdata + "\"" + "," + "\"" + (workid!=""?workid:"") + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

    }
}