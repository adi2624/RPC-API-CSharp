using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
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

        public string GetAddedNodeInfo(WebRequestPostExample httpInstance, Boolean dns, string node)
        {
            string json = httpInstance.CreateJsonRequest("getaddednodeinfo","[" + dns.ToString().ToLower() + "," + "\"" + node + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetConnectionCount(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getconnectioncount","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetDeprecationInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getdeprecationinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetNetTotals(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getnettotals","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetNetworkInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getnetworkinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetPeerInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getpeerinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string ListBanned(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("listbanned","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string Ping(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("ping","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
        
        public string SetBan(WebRequestPostExample httpInstance,string ip, string command, int bantime, Boolean absolute)
        {
            string json = httpInstance.CreateJsonRequest("setban","[" +"\"" + ip + "\"" + "," + "\"" + command + "\"" + "," + bantime.ToString() + "," + absolute.ToString().ToLower() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

    }
}