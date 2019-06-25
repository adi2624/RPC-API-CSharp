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