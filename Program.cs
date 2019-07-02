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

            Console.WriteLine("Testing GetInfo");
            result = httpInstance.GetInfo(httpInstance);    //ERROR: NEED HEX STRING TO CHECK.
            Console.WriteLine(result);

            Console.WriteLine("Testing Help");
            result = httpInstance.Help(httpInstance,"getaddressbalance");
            Console.WriteLine(result);

            /*
            Console.WriteLine("Testing Stop");
            result = httpInstance.Stop(httpInstance);
            Console.WriteLine(result);
             */
            Console.WriteLine("Testing Z_GetPaymentDisclosure");
            result = httpInstance.Z_GetPaymentDisclosure(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610","0", "0", "refund");   //No information available about transaction.
            Console.WriteLine(result);

            /*
            Could not write a test for Z_VAlidatePaymentDisclosure
             */            
            
            Console.WriteLine("Testing Generate");
            result = httpInstance.Generate(httpInstance,0);  //ERROR: CODE -32601 MESSAGE: MINInG ENABLED
            Console.WriteLine(result);


            Console.WriteLine("Testing GetGenerate");
            result = httpInstance.GetGenerate(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing SetGenerate");
            result = httpInstance.SetGenerate(httpInstance, false, 2);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockSubsidy");
            result = httpInstance.GetBlockSubsidy(httpInstance,1);
            Console.WriteLine(result);

            string[] capabilities = {};
            Console.WriteLine("Testing GetBlockTemplate");
            result = httpInstance.GetBlockTemplate(httpInstance,"disablecb",new List<String>(capabilities), ""); //ERROR: "Cannot get a block template while no peers are connected or chain not in sync!"}
            Console.WriteLine(result);

            Console.WriteLine("Testing GetLocalSolps");
            result = httpInstance.GetLocalSolps(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetMiningInfo");
            result = httpInstance.GetMiningInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetNetworkSlops");
            result = httpInstance.GetNetworkSolps(httpInstance,120,-1);
            Console.WriteLine(result);

            Console.WriteLine("Testing PrioritiSetTransaction");
            result = httpInstance.PrioritiseTransaction(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610",0.0,0);
            Console.WriteLine(result);

            Console.WriteLine("Testing SubmitBlock");
            result = httpInstance.SubmitBlock(httpInstance,"",""); //NEED HEX BLOCK ADDRESS TO CHECK.
            Console.WriteLine(result);

            /* 
            Console.WriteLine("Testing AddNode");
            result = httpInstance.AddNode(httpInstance, "127.0.0.1:10608","onetry");
            Console.WriteLine(result);
            */

            Console.WriteLine("Testing ClearBanned");
            result = httpInstance.ClearBanned(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing DisconnectNode");
            result = httpInstance.DisconnectNode(httpInstance,"127.0.0.1:10608");
            Console.WriteLine(result);

            Console.WriteLine("Testing DumpPrivKey");
            result = httpInstance.DumpPrivKey(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw");
            Console.WriteLine(result);

            Console.WriteLine("Testing EncryptWallet");
            result = httpInstance.EncryptWallet(httpInstance,"abc123");
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBalance");
            result = httpInstance.GetBalance(httpInstance,"",1,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetNewAddress");
            result = httpInstance.GetNewAddress(httpInstance,"");
            Console.WriteLine(result);

            Console.WriteLine("Testing ImportPrivKey");
            result = httpInstance.ImportPrivKey(httpInstance,"UtZS3VWNtACyVNsJa2GJaJ89xS7hvotn47WpiSYDE9SDD59xunzW","",true);
            Console.WriteLine(result);

            Console.WriteLine("Testing ImportWallet");
            result = httpInstance.ImportWallet(httpInstance,"");        //TEST INCOMPLETE
            Console.WriteLine(result);

            Console.WriteLine("Testing KeyPoolRefill");
            result = httpInstance.KeyPoolRefill(httpInstance,100);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListAddressGroupings");
            result = httpInstance.ListAddressGroupings(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListLockUnspent");
            result = httpInstance.ListLockUnspent(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListReceivedByAddress");
            result = httpInstance.ListReceivedByAddress(httpInstance,1,true,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListsinCeBlock");
            result = httpInstance.ListsInCeBlock(httpInstance,"027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71",1,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListTransactions");
            result = httpInstance.ListTransactions(httpInstance,"",10,0,false); 
            Console.WriteLine(result);


            string[] address_input = {""};
            Console.WriteLine("Testing ListUnspent");
            result = httpInstance.ListUnspent(httpInstance,1,9999999,new List<String>(address_input));
            Console.WriteLine(result);

            Console.WriteLine("Testing LockUnspent");
            result = httpInstance.LockUnspent(httpInstance,false,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610",0); 
            Console.WriteLine(result);

            Console.WriteLine("Testing ResendWalletTransactions");
            result = httpInstance.ResendWalletTransactions(httpInstance);
            Console.WriteLine(result);

            Dictionary<String,Double> dictionary_to_send = new Dictionary<String,Double>();
            string[] test_send_many_list = {""};
            dictionary_to_send.Add("REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw",0.02);
            Console.WriteLine("Testing SendMany");
            result = httpInstance.SendMany(httpInstance,dictionary_to_send,1,"",new List<String>(test_send_many_list));
            Console.WriteLine(result);

            Console.WriteLine("Testing SendToAddress");
            result = httpInstance.SendToAddress(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw",0.02,"hello","hi",true);
            Console.WriteLine(result);

            Console.WriteLine("Testing SetPubKey");
            result = httpInstance.SetPubKey(httpInstance,"0260801166cebdc9be1e3460ba9e4959fb29feee7725f565ffc296fa4636aa706f");
            Console.WriteLine(result);

            Console.WriteLine("Testing SetTxFee");
            result = httpInstance.SetTxFee(httpInstance,0.05);
            Console.WriteLine(result);
            
            Console.WriteLine("Testing SignMessage");
            result = httpInstance.SignMessage(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw", "signed");
            Console.WriteLine(result);

            Console.WriteLine("Testing WalletLock");
            result = httpInstance.WalletLock(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing WalletTestPhrase");
            result = httpInstance.WalletPassphrase(httpInstance,"abc123",0);
            Console.WriteLine(result);

            Console.WriteLine("Testing WalletPassphraseChange");
            result = httpInstance.WalletPassphraseChange(httpInstance,"abc123","abc124");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ExportKey");
            result = httpInstance.Z_ExportKey(httpInstance, "zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5"); //TEST FAILED.
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ExportViewingKey");
            result = httpInstance.Z_ExportViewingKey(httpInstance, "zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5"); //TEST FAILED.
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_export_wallet");
            result = httpInstance.Z_ExportWallet(httpInstance, "zwalletexport");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_GetBalance");
            result = httpInstance.Z_GetBalance(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw", 1);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_GetNewAddress");
            result = httpInstance.Z_GetNewAddress(httpInstance);
            Console.WriteLine(result);

            String contents = "["  + "opid-6a9da0dd-a950-4d95-848c-d3c18e44be03"  + "]";
            String[] contents_list = {contents};
            List<String> new_list = new List<String>(contents_list);
            Console.WriteLine("Testing GetOperationResult");
            result = httpInstance.Z_GetOperationResult(httpInstance,new_list);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetOperationStatus");
            result = httpInstance.Z_GetOperationStatus(httpInstance,new_list);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_GetTotalBalance");
            result = httpInstance.Z_GetTotalBalance(httpInstance,1,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ImportKey");
            result = httpInstance.Z_ImportKey(httpInstance,"Hwhf3O7QqwbPXhZcY+b8xWLBy0Im3CDDm+oVTZVaIi8oczkloc9VvEOh3rKXyb+34fju2KgUrhzdjxLWXMLlSAo=","whenkeyisnew",0);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ImportViewingKey");
            result = httpInstance.Z_ImportViewingKey(httpInstance,"Hwhf3O7QqwbPXhZcY+b8xWLBy0Im3CDDm+oVTZVaIi8oczkloc9VvEOh3rKXyb+34fju2KgUrhzdjxLWXMLlSAo=","whenkeyisnew",0);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ImportWallet");
            result = httpInstance.Z_ImportWallet(httpInstance,"/Users/adityarajguru/komodo/src/./zwalletexport");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ListAddresses");
            result = httpInstance.Z_ListAddresses(httpInstance,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ListOperationIDs");
            result = httpInstance.Z_ListOperationIds(httpInstance,"success");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ListReceivedByAddress");
            result = httpInstance.Z_ListReceivedByAddress(httpInstance, "zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5", 1);
            Console.WriteLine(result);

            string[] address_input_z = {"zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5"};
            Console.WriteLine("Testing Z_ListUnspent");
            result = httpInstance.Z_ListUnspent(httpInstance,1,9999999,false,new List<String>(address_input_z));
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_MergeToAddress");
            result = httpInstance.Z_MergeToAddress(httpInstance,new List<String>(address_input_z),"zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5",0.0002,0,0,"");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_SendMany");
            result = httpInstance.Z_SendMany(httpInstance, "zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5",dictionary_to_send,"",1,0.02); //ERROR
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ShieldCoinBase");
            result = httpInstance.Z_ShieldCoinBase(httpInstance,"zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5","zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5",0.01,5);
            Console.WriteLine(result);

            Console.WriteLine("Testing ZCBenchmark");
            result = httpInstance.ZCBenchmark(httpInstance,"time",1);
            Console.WriteLine(result);




            

        }

        /*
        WALLET COMMANDS
         */

        
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

        public string DumpPrivKey(WebRequestPostExample httpInstance, string address)
        {
            string json_request_data = httpInstance.CreateJsonRequest("dumpprivkey", "[" + "\"" +address + "\"" + "]" );
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
        
        public string EncryptWallet(WebRequestPostExample httpInstance, string passphrase)
        {
            string json_request_data = httpInstance.CreateJsonRequest("encryptwallet", "["  + "\"" + passphrase  + "\"" + "]" );
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

        public string GetBalance(WebRequestPostExample httpInstance, string account, int minconf, Boolean includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getbalance", "[" + "\""  + "\"" + "," + minconf.ToString() + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string GetNewAddress(WebRequestPostExample httpInstance, string account)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getnewaddress", "[" +  "]" );
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

        public string ImportPrivKey(WebRequestPostExample httpInstance, string priv_key, string label, Boolean rescan)
        {
            string json = httpInstance.CreateJsonRequest("importprivkey", "[" +  "\""+ priv_key + "\"" + ","  +  "\"" +  label +  "\""  + ","  + rescan.ToString().ToLower()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string ImportWallet(WebRequestPostExample httpInstance, string path)
        {
            string json_request_data = httpInstance.CreateJsonRequest("importwallet", "[" + "\"" + path + "\"" + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string KeyPoolRefill(WebRequestPostExample httpInstance, int newsize)
        {
            string json_request_data = httpInstance.CreateJsonRequest("keypoolrefill", "["  + newsize.ToString() + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string ListAddressGroupings(WebRequestPostExample httpInstance)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listaddressgroupings", "["  + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string ListLockUnspent(WebRequestPostExample httpInstance)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listlockunspent", "["  + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string ListReceivedByAddress(WebRequestPostExample httpInstance,int minconf,Boolean includeEmpty, Boolean includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listreceivedbyaddress", "["  + minconf.ToString() + "," + includeEmpty.ToString().ToLower() + "," + includeWatchOnly.ToString().ToLower() + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string ListsInCeBlock(WebRequestPostExample httpInstance, string blockhash, int targetconf, Boolean includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listsinceblock", "["  + "\"" + blockhash + "\""  + "," + targetconf.ToString() + "," + includeWatchOnly.ToString().ToLower() + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string ListTransactions(WebRequestPostExample httpInstance,string account, int count, int skip, Boolean includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listtransactions", "["  + "\"" + "*" + "\""  + "," + count.ToString() + "," + skip.ToString() + "," + includeWatchOnly.ToString().ToLower() + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string ListUnspent(WebRequestPostExample httpInstance,int minconf,int maxconf,List<String> addresses)
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

            string json = httpInstance.CreateJsonRequest("listunspent","[" +  minconf.ToString() + ","  + maxconf.ToString() + "," + addr_list + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string LockUnspent(WebRequestPostExample httpInstance, Boolean unlock, string txid, int vout)
        {
            string json = httpInstance.CreateJsonRequest("lockunspent","["  + unlock.ToString().ToLower() + "," + "[{" + "\"txid\":"  + "\"" + txid  + "\""  + "," + "\"vout"  + "\"" +  ":" + vout  + "}]]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string ResendWalletTransactions(WebRequestPostExample httpInstance)
        {
            string json_request_data = httpInstance.CreateJsonRequest("resendwallettransactions", "["  + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        public string SendMany(WebRequestPostExample httpInstance, Dictionary<String,Double> amounts, int minconf, string comment, List<String> subtract_fee)
        {
            string amount_list = "{";
            foreach(var amount_individual in amounts)
                {
                    amount_list = amount_list + "\"" + amount_individual.Key + "\"" + ":" + amount_individual.Value + ",";
                }
            if(amount_list.Length > 1)
                {
                    amount_list = amount_list.Substring(0, (amount_list.Length - 1 ) );
                }

            amount_list = amount_list + "}";

            string subtract_list = "[";
            foreach(var fee_individual in subtract_fee)
            {
                subtract_list = subtract_list + "\"" + fee_individual + "\"" + ",";
            }
            
            if(subtract_list.Length > 1)
                {
                    subtract_list = subtract_list.Substring(0, (subtract_list.Length - 1 ) );
                }

            subtract_list = subtract_list + "]";

            string json = httpInstance.CreateJsonRequest("sendmany","[" +  "\"" + "\"" + ","  + amount_list + "," + minconf.ToString() +"," + "\"" + comment.ToString() + "\"" + "," + subtract_list + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string SendToAddress(WebRequestPostExample httpInstance, string address, Double amount, string comment, string comment_to, Boolean subtract_amount_from_fee)
        {
            string json = httpInstance.CreateJsonRequest("sendtoaddress","[" +  "\"" + address + "\"" + "," + amount.ToString() +"," + "\"" + comment + "\"" + "," + "\"" + comment_to + "\"" + "," + subtract_amount_from_fee.ToString().ToLower() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string SetPubKey(WebRequestPostExample httpInstance, string pubkey)
        {
            string json = httpInstance.CreateJsonRequest("setpubkey","[" + "\"" +  pubkey + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string SetTxFee(WebRequestPostExample httpInstance,Double amount)
        {
            string json = httpInstance.CreateJsonRequest("settxfee","["  +  amount.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string SignMessage(WebRequestPostExample httpInstance, string address, string message)
        {
            string json = httpInstance.CreateJsonRequest("signmessage","[" + "\"" +  address+ "\"" + "," + "\"" + message + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string WalletLock(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("walletlock","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string WalletPassphrase(WebRequestPostExample httpInstance, string passphrase, int timeout)
        {
            string json = httpInstance.CreateJsonRequest("walletpassphrase","[" + "\"" +  passphrase + "\"" + "," + timeout.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string WalletPassphraseChange(WebRequestPostExample httpInstance, string oldpassphrase, string newpassphrase)
        {
            string json = httpInstance.CreateJsonRequest("walletpassphrasechange","[" + "\"" +  oldpassphrase + "\"" + "," + "\"" + newpassphrase + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ExportKey(WebRequestPostExample httpInstance, string z_address)
        {
            string json = httpInstance.CreateJsonRequest("z_exportkey","[" + "\"" +  z_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ExportViewingKey(WebRequestPostExample httpInstance, string z_address)
        {
            string json = httpInstance.CreateJsonRequest("z_exportviewingkey","[" + "\"" +  z_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ExportWallet(WebRequestPostExample httpInstance,string filename)
        {
            string json = httpInstance.CreateJsonRequest("z_exportwallet","[" + "\"" +  filename + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_GetBalance(WebRequestPostExample httpInstance, string address, int minconf)
        {
            string json = httpInstance.CreateJsonRequest("z_getbalance","[" + "\"" +  address + "\"" + "," + minconf.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_GetNewAddress(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("z_getnewaddress","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_GetOperationResult(WebRequestPostExample httpInstance, List<String> operation_id)
        {
            String op_list = "[";
            foreach(var op_individual in operation_id)
                {
                    op_list = op_list + "\"" + op_individual + "\"" + ",";
                }
            if(op_list.Length > 1)
                {
                    op_list = op_list.Substring(0, (op_list.Length - 1 ) );
                }

            op_list = op_list + "]";

            string json = httpInstance.CreateJsonRequest("z_getoperationresult","[" + op_list +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_GetOperationStatus(WebRequestPostExample httpInstance, List<String> operation_id)
        {
             String op_list = "[";
            foreach(var op_individual in operation_id)
                {
                    op_list = op_list + "\"" + op_individual + "\"" + ",";
                }
            if(op_list.Length > 1)
                {
                    op_list = op_list.Substring(0, (op_list.Length - 1 ) );
                }

            op_list = op_list + "]";

            string json = httpInstance.CreateJsonRequest("z_getoperationstatus","[" + op_list +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_GetTotalBalance(WebRequestPostExample httpInstance, int minconf, Boolean includeWatchOnly)
        {
            string json = httpInstance.CreateJsonRequest("z_gettotalbalance","[" + minconf.ToString() + "," + includeWatchOnly.ToString().ToLower() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ImportKey(WebRequestPostExample httpInstance, string z_privatekey, string rescan, int startheight)
        {
            string json = httpInstance.CreateJsonRequest("z_importkey","[" + "\"" + z_privatekey + "\"" + "," + "\"" + rescan + "\"" + "," + startheight.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ImportViewingKey(WebRequestPostExample httpInstance,string viewing_key, string rescan, int startheight)
        {
            string json = httpInstance.CreateJsonRequest("z_importviewingkey","[" + "\"" + viewing_key + "\"" + "," + "\"" + rescan + "\"" + "," + startheight.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ImportWallet(WebRequestPostExample httpInstance, string filename)
        {
            string json = httpInstance.CreateJsonRequest("z_importwallet","[" + "\"" + filename + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ListAddresses(WebRequestPostExample httpInstance,Boolean includeWatchOnly)
        {
            string json = httpInstance.CreateJsonRequest("z_listaddresses","[" + includeWatchOnly.ToString().ToLower() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ListOperationIds(WebRequestPostExample httpInstance,string status)
        {
            string json = httpInstance.CreateJsonRequest("z_listoperationids","[" + "\"" + status + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ListReceivedByAddress(WebRequestPostExample httpInstance, string address, int minconf)
        {
            string json = httpInstance.CreateJsonRequest("z_listreceivedbyaddress","[" + "\"" + address + "\"" + "," + minconf.ToString()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ListUnspent(WebRequestPostExample httpInstance, int minconf, int maxconf, Boolean includeWatchOnly, List<String> addresses)
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

            string json = httpInstance.CreateJsonRequest("z_listunspent","[" +  minconf.ToString() + ","  + maxconf.ToString() + "," + includeWatchOnly.ToString().ToLower() + "," + addr_list + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_MergeToAddress(WebRequestPostExample httpInstance, List<String> from_addresses, string to_address, Double fee, int transparent_limit, int shielded_limit, string memo)
        {
            String addr_list = "[";
            foreach(var address_individual in from_addresses)
                {
                    addr_list = addr_list + "\"" + address_individual + "\"" + ",";
                }
            if(addr_list.Length > 1)
                {
                    addr_list = addr_list.Substring(0, (addr_list.Length - 1 ) );
                }

            addr_list = addr_list + "]";

            string json = httpInstance.CreateJsonRequest("z_mergetoaddress","[" + addr_list + "," + "\"" + to_address + "\"" + "," + (fee!=0.0001?fee.ToString():"\""+"\"") + "," + (transparent_limit!=50?transparent_limit.ToString():"\""+"\"") + "," + (shielded_limit!=10?shielded_limit.ToString():"\""+"\"") + (memo!=""?memo:"\""+"\"") + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_SendMany(WebRequestPostExample httpInstance,string fromaddress,Dictionary<String,Double> amounts, string memo, int minconf, Double fee)
        {
            string amount_list = "{";
            foreach(var amount_individual in amounts)
                {
                    amount_list = amount_list + "\"" + amount_individual.Key + "\"" + ":" + amount_individual.Value + ",";
                }
            if(amount_list.Length > 1)
                {
                    amount_list = amount_list.Substring(0, (amount_list.Length - 1 ) );
                }

            amount_list = amount_list + "}";

            string json = httpInstance.CreateJsonRequest("z_sendmany","[" + "\"" + fromaddress + "\"" + "," + amount_list + "," + (memo!=""?memo:"\""+"\"") + "," + (minconf!=1?minconf.ToString():"\""+"\"") + "," + (fee!=0.0001?fee.ToString():"\""+"\"") + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ShieldCoinBase(WebRequestPostExample httpInstance, string fromaddress, string to_address, double fee, int limit)
        {
            string json = httpInstance.CreateJsonRequest("z_shieldcoinbase","[" + "\"" + fromaddress + "\"" + "," + "\"" + to_address  +  "\"" + "," + (fee!=0.0001?fee.ToString():"\"" + "\"") + "," + (limit!=50?limit.ToString():"\"" + "\"")+ "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string ZCBenchmark(WebRequestPostExample httpInstance, string benchmark_type, int samplecount)
        {
            string json = httpInstance.CreateJsonRequest("zcbenchmark","[" + "\"" + benchmark_type + "\"" + "," + samplecount.ToString() +  "]" );
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

        /*
        DISCLOSURE COMMANDS
         */

        public string Z_GetPaymentDisclosure(WebRequestPostExample httpInstance, string txid, string js_index, string output_index, string message)
        {
            string json = httpInstance.CreateJsonRequest("z_getpaymentdisclosure","[" + "\"" + txid + "\"" + "," + "\"" + js_index + "\"" + "," + "\"" + output_index + "\"" + "," + "\"" + message + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Z_ValidatePaymentDisclosure(WebRequestPostExample httpInstance, string payment_disclosure)
        {
            string json = httpInstance.CreateJsonRequest("z_validatepaymentdisclosure","[" + "\"" + payment_disclosure + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

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

        public string jumblr_secret(WebRequestPostExample httpInstance, DownloadStringCompletedEventArgs secret_address)
        {
            string json = httpInstance.CreateJsonRequest("jumblr_secret","[" + "\"" + secret_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

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

        /*
        NETWORK COMMANDS
         */
        
        public string AddNode(WebRequestPostExample httpInstance, string node, string command)
        {
            string json = httpInstance.CreateJsonRequest("addnode","[" + "\"" + node + "\"" + "," + "\"" + command + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string ClearBanned(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("clearbanned","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string DisconnectNode(WebRequestPostExample httpInstance, string node)
        {
            string json = httpInstance.CreateJsonRequest("disconnectnode","[" + "\"" + node + "\"" +  "]" );
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