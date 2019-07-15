using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         /*
        MINING COMMANDS
         */

        
        /*
        The getblocksubsidy method returns the block-subsidy reward.
        :param height: (numeric, optional) the block height; if the
            block height is not provided, the method defaults to the
            current height of the chain
        :return: "miner" (numeric) the mining reward amount
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

        /*
        The getblocktemplate method returns data that is necessary
        to construct a block.
        :param mode: (string, optional)	this must be set to
            "template" or omitted
        :param capabilities: [string, optional] a list of capability strings
        :param support: (string) client side supported features: "longpoll",
            "coinbasetxn", "coinbasevalue", "proposal", "serverlist", "workid"
        :return: JSON string with details necessary to construct a block.
         */
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

        /*
         The getlocalsolps method returns the average local solutions
        per second since this node was started.
        :return: "data" (numeric) the solutions-per-second average
         */
        public string GetLocalSolps(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getlocalsolps","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The getmininginfo method returns a json object containing
        mining-related information.
        :return: JSON string with mining-related information.
         */
        public string GetMiningInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getmininginfo","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getnetworksolps method returns the estimated network
        solutions per second based on the last n blocks.
        :param blocks: (numeric, optional, default=120)
            the number of blocks; use -1 to calculate according
            to the relevant difficulty averaging window
        :param height: (numeric, optional, default=-1) the block
            height that corresponds to the requested data
        :return: data (numeric) solutions per second, estimated
         */
        public string GetNetworkSolps(WebRequestPostExample httpInstance, int blocks, int height)
        {
            string json = httpInstance.CreateJsonRequest("getnetworksolps","[" + blocks.ToString() + "," + height.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The prioritisetransaction method instructs the daemon to accept
        the indicated transaction into mined blocks at a higher
        (or lower) priority.
        :param txid: (string, required)	the transaction id
        :param priority_delta: (numeric, required) the priority to add
            or subtract (if negative).
        :param fee_delta: (numeric, required) the fee value in satoshis
            to add or subtract (if negative);
        :return: true (JSON string) returns true
         */
        public string PrioritiseTransaction(WebRequestPostExample httpInstance, string txid, double priority_delta, int fee_delta)
        {
            string json = httpInstance.CreateJsonRequest("prioritisetransaction","[" + "\"" + txid + "\"" + "," + priority_delta.ToString()+ "," + fee_delta.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }      

        /*
        The submitblock method instructs the daemon to propose a new block
        to the network.
        :param hexdata: (string, required)	the hex-encoded block data
            to submit.
        :param workid: (string, sometimes optional)	if the server provides
            a workid, it MUST be included with submissions
        :return: JSON string containing:
            "duplicate": the node already has a valid copy of the block
            "duplicate-invalid": the node already has the block,
                but it is invalid
            "duplicate-inconclusive": the node already has the block
                but has not validated it
            "inconclusive" the node has not validated the block, it may
                not be on the node's current best chain
            "rejected" the block was rejected as invalid
         */

        public string SubmitBlock(WebRequestPostExample httpInstance, string hexdata, string workid)
        {
            string json = httpInstance.CreateJsonRequest("submitblock","[" + "\"" + hexdata + "\"" + "," + "\"" + (workid!=""?workid:"") + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

    }
}