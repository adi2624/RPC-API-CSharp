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

                catch(Exception ex)
                {
                    Console.Write(ex.ToString());
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