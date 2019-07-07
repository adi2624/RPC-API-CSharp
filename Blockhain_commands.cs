using System;
using System.Collections.Generic;

namespace Blockchain
{


    public partial class WebRequestPostExample
    {
            /*

            BLOCKCHAIN COMMANDS

            */
        public string CoinSupply(WebRequestPostExample httpInstance, int height)
        {

            string json;

            if(height>1)
            {
                json = httpInstance.CreateJsonRequest("coinsupply","[" + "\"height.ToString()\"" +  "]" );
            }
            else
            {
                json = httpInstance.CreateJsonRequest("coinsupply","[" +  "]" );
            }

            string result = CallHttpRequest(json);
            return result;

        }


        public string GetBestBlockHash(WebRequestPostExample httpInstance)
        {

            string json = httpInstance.CreateJsonRequest("getbestblockhash","["  +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetBlock(WebRequestPostExample httpInstance, string block_id, Boolean verbose)
        {
            /*
            BLOCK ID CAN ONLY BE PASSED IN AS A STRING
             */

            string json = httpInstance.CreateJsonRequest("getblock","[" + "\"" + block_id + "\"" +  "," + verbose.ToString().ToLower() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetBlockChainInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getblockchaininfo","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetBlockCount(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getblockcount","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetBlockHash(WebRequestPostExample httpInstance, int index)
        {
            string json = httpInstance.CreateJsonRequest("getblockhash","[" + index.ToString()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetBlockHashes(WebRequestPostExample httpInstance, int high, int low, Boolean orphans,Boolean logical_times)
        {
            string options = "{\"noOrphans\":" + orphans.ToString().ToLower() + "," + "\"logicalTimes\":" + logical_times.ToString().ToLower() + "}" ;
            string json = httpInstance.CreateJsonRequest("getblockhashes","["  + high.ToString()  + ","  + low.ToString() + "," + options + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetBlockHeader(WebRequestPostExample httpInstance, string hash, Boolean verbose)
        {
            string json = httpInstance.CreateJsonRequest("getblockheader","[" + "\"" + hash.ToString()  + "\"" + ","  + verbose.ToString().ToLower()   + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetChainTxStats(WebRequestPostExample httpInstance, int num_blocks, string blockhash)
        {
            string json = httpInstance.CreateJsonRequest("getchaintxstats","["  + num_blocks.ToString()  + ","  + "\"" + blockhash +"\""  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetDifficulty(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getdifficulty","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetLastSegIdStakes(WebRequestPostExample httpInstance, int depth)
        {
            string json = httpInstance.CreateJsonRequest("getlastsegidstakes","[" + depth.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetChainTips(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getchaintips","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetMemPoolInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getmempoolinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetRawMempool(WebRequestPostExample httpInstance, Boolean verbose)
        {
            string json = httpInstance.CreateJsonRequest("getrawmempool","[" + verbose.ToString().ToLower() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetSpentInfo(WebRequestPostExample httpInstance, string txid, int index)
        {
            string options = "{\"txid\":" + "\"" + txid.ToLower() + "\"" + "," + "\"index\":" + index.ToString() + "}";
            string json = httpInstance.CreateJsonRequest("getspentinfo","[" + options +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetTxOut(WebRequestPostExample httpInstance, string txid, int vout, Boolean includemempool)
        {
            string json = httpInstance.CreateJsonRequest("gettxout","[" + "\"" + txid + "\"" + "," + vout.ToString() + "," + includemempool.ToString().ToLower() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetTxOutProof(WebRequestPostExample httpInstance, List<String> txid, string blockhash)
        {
            String tx_list = "[";
            foreach(var address_individual in txid)
                {
                    tx_list = tx_list + "\"" + address_individual + "\"" + ",";
                }
            if(tx_list.Length > 1)
                {
                    tx_list = tx_list.Substring(0, (tx_list.Length - 1 ) );
                }

            tx_list =tx_list + "]";
            string json;
            if(blockhash!="")
            {
                json = httpInstance.CreateJsonRequest("gettxoutproof","[" +tx_list + "," + "\"" + blockhash.ToString() + "\"" +  "]" );
            }
            else
            {
                json = httpInstance.CreateJsonRequest("gettxoutproof","[" +tx_list + ","  + ""  +  "]" );
            }
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetTxOutSetInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("gettxoutsetinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string KvSearch(WebRequestPostExample httpInstance, string key)
        {
            string json = httpInstance.CreateJsonRequest("kvsearch","[" + "\"" + key + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string KvUpdate(WebRequestPostExample httpInstance, string key, string value, int days, string passphrase)
        {
            string json = httpInstance.CreateJsonRequest("kvupdate","[" + "\"" + key + "\"" + "," + "\"" + value + "\"" + "," + "\"" + days.ToString() + "\"" + "," + "\"" + passphrase + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string MinerIds(WebRequestPostExample httpInstance, int height)
        {
            string json = httpInstance.CreateJsonRequest("minerids","[" + "\"" + height.ToString() +  "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Notaries(WebRequestPostExample httpInstance, int height, int timestamp)
        {
            string options;
            if(height!=0 && timestamp!=0)
                {
                options =  "\"" + height.ToString() + "\"" + "," + "\"" + timestamp.ToString()+ "\"" ;
                }
            else if(height!=0)
                {
                    options = "(" + "\"" + height.ToString() + "\"" +"}";
                }
            else
                {
                    options = "(" + "\"" + timestamp.ToString()+ "\"" + "}";
                }
            string json = httpInstance.CreateJsonRequest("notaries","[" + options +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string VerifyChain(WebRequestPostExample httpInstance, int check_level, int num_blocks)
        {
            string json = httpInstance.CreateJsonRequest("verifychain","[" + check_level.ToString() + "," + num_blocks.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string VerifyTxOutProof(WebRequestPostExample httpInstance, string proofstring)
        {
            string json = httpInstance.CreateJsonRequest("verifytxoutproof","[" + "\"" + proofstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}