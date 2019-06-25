using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Blockchain
{
    public class WebRequestPostExample
    {
        
        public static void Main()
        {
            // Create a request using a URL that can receive a post.   
            
            WebRequestPostExample httpInstance = new WebRequestPostExample();
            string result = httpInstance.GetWalletInfo(httpInstance);
            Console.WriteLine(result);

            result = httpInstance.BackupWallet(httpInstance,"backup");
            Console.WriteLine(result);

            result = httpInstance.DumpWallet(httpInstance, "backup");
            Console.WriteLine(result);

            result = httpInstance.GetAccount(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw");
            Console.WriteLine(result);

            Console.WriteLine("Testing Dump Private Key: ");
            result = httpInstance.DumpPrivateKey(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw" );
            Console.WriteLine(result);

            Console.WriteLine("Testing Get Raw Change Address");
            result = httpInstance.GetRawChangeAddress(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing Get Received by Address");
            result = httpInstance.GetReceivedByAddress(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw", "1");
            Console.WriteLine(result);

            Console.WriteLine("Testing Get Transaction");
            result = httpInstance.GetTransaction(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610" , "False");
            Console.WriteLine(result);

            Console.WriteLine("Testing Get Unconfirmed Balance");
            result = httpInstance.GetUnconfirmedBalance(httpInstance);
            Console.WriteLine(result);
            
            Console.WriteLine("Testing Import Address");
            result = httpInstance.ImportAddress(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw" , "testing", "True");
            Console.WriteLine(result);
            //Getting Error. The Wallet already contains private key for this address or script.

            Console.WriteLine("Testing GetAddressBalance");
            string[] input = {"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw"};
            result = httpInstance.GetAddressBalance(httpInstance, new List<string>(input));
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddressDeltas");
            result = httpInstance.GetAddressDeltas(httpInstance, new List<string>(input), 0, 0, false);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddressMemPool");
            result = httpInstance.GetAddressMemPool(httpInstance, new List<string>(input));
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddressTxIds");
            result = httpInstance.GetAddressTxIds(httpInstance, new List<string>(input), 0, 0);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddressUTxos");
            result = httpInstance.GetAddressUTuxos(httpInstance, new List<string>(input), false);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetSnapshot");
            result = httpInstance.GetSnapshot(httpInstance, 0);
            Console.WriteLine(result);

            Console.WriteLine("Testing CoinSupply");
            result = httpInstance.CoinSupply(httpInstance,0);       //ERROR: Could not Calculate Supply
            Console.WriteLine(result);
            
            Console.WriteLine("Testing GetBestBlockHash");
            result = httpInstance.GetBestBlockHash(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlock");
            result = httpInstance.GetBlock(httpInstance, "027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71",false);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockChainInfo");
            result = httpInstance.GetBlockChainInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockCount");
            result = httpInstance.GetBlockCount(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockHash");
            result = httpInstance.GetBlockHash(httpInstance, 0);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockHashes");
            result = httpInstance.GetBlockHashes(httpInstance, 0,1,true,true);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockHeader");
            result = httpInstance.GetBlockHeader(httpInstance,"027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71", true );
            Console.WriteLine(result);

            Console.WriteLine("Testing GetChainTips");
            result = httpInstance.GetChainTips(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetChainTxStats");
            result = httpInstance.GetChainTxStats(httpInstance,0,"027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71");
            Console.WriteLine(result);

            Console.WriteLine("Testing GetDifficulty");
            result = httpInstance.GetDifficulty(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetlastSegIDStakes");
            result = httpInstance.GetLastSegIdStakes(httpInstance,1);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetMemPoolInfo");
            result = httpInstance.GetMemPoolInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetRawMemPool");
            result = httpInstance.GetRawMempool(httpInstance,true);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetSpentInfo");
            result = httpInstance.GetSpentInfo(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610", 0);  //ERROR: UNABLE TO GET SPENT INFO
            Console.WriteLine(result);

            Console.WriteLine("Testing GetTxOut");
            result = httpInstance.GetTxOut(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610", 0, false);
            Console.WriteLine(result);


            string[] test_input = {"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610"};
            Console.WriteLine("Testing GetTxOutProof");
            result = httpInstance.GetTxOutProof(httpInstance,new List<String>(test_input), "027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71");
            Console.WriteLine(result);

            Console.WriteLine("Testing GetTxOutSetInfo");
            result = httpInstance.GetTxOutSetInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing KvSearch");
            result = httpInstance.KvSearch(httpInstance, "key");
            Console.WriteLine(result);

            Console.WriteLine("Testing KvUpdate");
            result = httpInstance.KvUpdate(httpInstance, "key","value", 0, "password"); //ERROR:INSUFFICIENT FUNDS.
            Console.WriteLine(result);

            Console.WriteLine("Testing MinerIds");
            result = httpInstance.MinerIds(httpInstance, 0); //ERROR: COULD NOT EXTRACT MINER IDS.
            Console.WriteLine(result);

            Console.WriteLine("Testing Notaries");
            result = httpInstance.Notaries(httpInstance,1,1); 
            Console.WriteLine(result);

            Console.WriteLine("Testing VerifyChain");
            result = httpInstance.VerifyChain(httpInstance,0,0); 
            Console.WriteLine(result);

            Console.WriteLine("Testing VerifyTxOutProof");
            result = httpInstance.VerifyTxOutProof(httpInstance,"null");    //ERROR: NEED HEX STRING TO CHECK.
            Console.WriteLine(result);
            
        }

        public string GetWalletInfo(WebRequestPostExample httpInstance)
            {
                
                //string json = "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"getwalletinfo\", \"params\": [] }";
                string json = httpInstance.CreateJsonRequest("getwalletinfo","[]");
                string result = CallHttpRequest(json);
                return result;
            }
        

        public string BackupWallet(WebRequestPostExample httpInstance,string filename)
        {
            
            //string json_request_data = "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"backupwallet\", \"params\": [\""+filename+"\"] }";
            string json_request_data = httpInstance.CreateJsonRequest("backupwallet","[" + "\"" + filename + "\"" + "]");
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string DumpWallet(WebRequestPostExample httpInstance,string filename)
            {
                //string json_request_data = "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"dumpwallet\", \"params\": [\"" + filename + "\"] }";
                string json_request_data = httpInstance.CreateJsonRequest("dumpwallet", "[" + "\"" + filename + "\"" + "]" );
                string result = CallHttpRequest(json_request_data);
                return result;

            }

        public string GetAccount(WebRequestPostExample httpInstance, string address)
        {
           
            //string json_request_data = "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"getaccount\", \"params\": [\"" + address + "\"] }";
            string json_request_data = httpInstance.CreateJsonRequest("getaccount", "[" + "\"" + address + "\"" + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string DumpPrivateKey(WebRequestPostExample httpInstance, string address)
        {
            string json_request_data = httpInstance.CreateJsonRequest("dumpprivkey", "[" + "\"" + address + "\"" + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string GetRawChangeAddress(WebRequestPostExample httpInstance)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getrawchangeaddress","[]");
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string GetReceivedByAddress(WebRequestPostExample httpInstance, string address, string minconf)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getreceivedbyaddress","[" +  "\""+ address + "\"" + ","  + minconf   + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string GetTransaction(WebRequestPostExample httpInstance, string txid, string includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getreceivedbyaddress","[" +  "\""+ txid + "\"" + ","  +  "\"" +  includeWatchOnly +  "\""  + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string GetUnconfirmedBalance(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getunconfirmedbalance","[]");
            string result = CallHttpRequest(json);
            return result;
        }

        public string ImportAddress(WebRequestPostExample httpInstance, string address, string label, string rescan)
        {
            string json = httpInstance.CreateJsonRequest("importaddress", "[" +  "\""+ address + "\"" + ","  +  "\"" +  label +  "\""  + ","  + rescan.ToLower()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

/*

ADDRESS COMMANDS

 */
        public string GetAddressBalance(WebRequestPostExample httpInstance, List<String> addresses)
        {
            String addr_list = "[";
            foreach(var address_individual in addresses)
                {
                    addr_list = addr_list + "\"" + address_individual + "\"" + ",";
                }
            if(addr_list.Length > 1)
                {
                    addr_list = addr_list.Substring(0, (addr_list.Length - 1 ) );
                }

            addr_list = addr_list + "]";

            string json = httpInstance.CreateJsonRequest("getaddressbalance","[{" + "\"addresses\":"  + addr_list + "}]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetAddressDeltas(WebRequestPostExample httpInstance, List<String> addresses, int start, int end, Boolean chaininfo)
            {
                String addr_list = "[";
                foreach(var address_individual in addresses)
                    {
                        addr_list = addr_list + "\"" + address_individual + "\"" + ",";
                    }
                if(addr_list.Length > 1)
                    {
                        addr_list = addr_list.Substring(0, (addr_list.Length - 1 ) );
                    }

                addr_list = addr_list + "]";
                string json = httpInstance.CreateJsonRequest("getaddressdeltas","[{" + "\"addresses\":"  + addr_list + "," + "\"start\":"  + start.ToString()  + "," + "\"end\":" +    end.ToString()  + "," + "\"chainInfo\":" + "\"" + chaininfo.ToString().ToLower() + "\"" + "}]" );
                string result = CallHttpRequest(json);
                return result;
            }

        public string GetAddressMemPool(WebRequestPostExample httpInstance, List<String> addresses)
            {
                String addr_list = "[";
            foreach(var address_individual in addresses)
                {
                    addr_list = addr_list + "\"" + address_individual + "\"" + ",";
                }
            if(addr_list.Length > 1)
                {
                    addr_list = addr_list.Substring(0, (addr_list.Length - 1 ) );
                }

            addr_list = addr_list + "]";

            string json = httpInstance.CreateJsonRequest("getaddressmempool","[{" + "\"addresses\":"  + addr_list + "}]" );
            string result = CallHttpRequest(json);
            return result;
            }

        public string GetAddressTxIds(WebRequestPostExample httpInstance, List<String> addresses, int start, int end)
        {
            String addr_list = "[";
            foreach(var address_individual in addresses)
                {
                    addr_list = addr_list + "\"" + address_individual + "\"" + ",";
                }
            if(addr_list.Length > 1)
                {
                    addr_list = addr_list.Substring(0, (addr_list.Length - 1 ) );
                }

            addr_list = addr_list + "]";
            string json = httpInstance.CreateJsonRequest("getaddresstxids","[{" + "\"addresses\":"  + addr_list + "," + "\"start\":"  + start.ToString()  + "," + "\"end\":" +    end.ToString()   + "}]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetAddressUTuxos(WebRequestPostExample httpInstance, List<String> addresses, Boolean chaininfo)
        {
            String addr_list = "[";
                foreach(var address_individual in addresses)
                    {
                        addr_list = addr_list + "\"" + address_individual + "\"" + ",";
                    }
                if(addr_list.Length > 1)
                    {
                        addr_list = addr_list.Substring(0, (addr_list.Length - 1 ) );
                    }

                addr_list = addr_list + "]";
                string json = httpInstance.CreateJsonRequest("getaddressutxos","[{" + "\"addresses\":"  + addr_list + "," + "\"chainInfo\":" + "\"" + chaininfo.ToString().ToLower() + "\"" + "}]" );
                string result = CallHttpRequest(json);
                return result;
        }

        public string GetSnapshot(WebRequestPostExample httpInstance, int top)
        {
            string json = httpInstance.CreateJsonRequest("getsnapshot","[" + "\"top.ToString()\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }


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
        public string CallHttpRequest(string json_request_data)
        {
             var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:10607/");
                httpWebRequest.Credentials = new NetworkCredential("user2027525480","pass8bd57d606607e3978406658840c66a1db7b44d24c75991c122589863eaf3893569");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());

                using(streamWriter)
                    {
                        //Console.WriteLine(json_request_data);
                        streamWriter.Write(json_request_data);
                    }
                 try
                {
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());
                    using(streamReader)
                    {
                        var result = streamReader.ReadToEnd();
                        return result;
                    }
                }

                catch(WebException ex)
                {   
                    
                    var resp = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(resp);
                }

                return null;

        }

        public String CreateJsonRequest(string MethodName, string parameters)
        {
            Dictionary<string,string> request_parameters = new Dictionary<string,string>();
            request_parameters.Add("jsonrpc","1.0");
            request_parameters.Add("id","curltest");
            request_parameters.Add("method",MethodName);
            request_parameters.Add("params",parameters);

            string parsed_request = "{";

            foreach (string key in request_parameters.Keys)
                    {
                        if(key!="params")
                        {
                            parsed_request += "\"" +  WebUtility.UrlEncode(key) + "\"" + ":"
                                +  "\"" + request_parameters[key] +  "\"" + ",";
                        }
                        else
                        {
                            parsed_request += "\"" +  WebUtility.UrlEncode(key) + "\"" + ":"
                                 + request_parameters[key] ;
                        }
                    }                       

            parsed_request = parsed_request + "}";
            Console.WriteLine(parsed_request);
            return parsed_request;
            
        }

        
    }

    
}