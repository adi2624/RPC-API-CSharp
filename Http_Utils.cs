using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
namespace Blockchain
{
    public partial class WebRequestPostExample
    {
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