using System;
using System.Collections.Generic;

namespace Blockchain
{


    public partial class WebRequestPostExample
    {
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


    }
}