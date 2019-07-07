using System;
using System.Collections.Generic;

namespace Blockchain
{

public partial class WebRequestPostExample
{
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
}

}