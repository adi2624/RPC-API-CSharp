using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         /*
        NETWORK COMMANDS
         */
        
        /*
        The addnode method attempts to add or remove a node from the
        addnode list, or to make a single attempt to connect to a node.
        :param node: (string, required) node_ip:port
        :param command: (string, required) 'add' to add a node to the list,
            'remove' to remove a node from the list,
            'onetry' to try a connection to the node once
        :return: JSON string
         */
        public string AddNode(WebRequestPostExample httpInstance, string node, string command)
        {
            string json = httpInstance.CreateJsonRequest("addnode","[" + "\"" + node + "\"" + "," + "\"" + command + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The clearbanned method clears all banned IPs
        :return: JSON string
        */
        public string ClearBanned(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("clearbanned","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The disconnectnode method instructs the daemon to immediately
        disconnect from the specified node.
        :param node: (string, required) node_ip:port
        :return: JSON string
         */
        public string DisconnectNode(WebRequestPostExample httpInstance, string node)
        {
            string json = httpInstance.CreateJsonRequest("disconnectnode","[" + "\"" + node + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getaddednodeinfo method returns information about the given
            added node, or all added nodes.
            Nodes added via onetry are not listed here.
            :param dns: (boolean, required) if false, only a list of added nodes
                will be provided; otherwise, connection information is also provided
            :param node: (string, optional)	if provided, the method returns
                information about this specific node;
                otherwise, all nodes are returned
            :return: JSON string containing:
                "addednode" (string) the node ip address
                "connected" (boolean) if connected
                "addresses" [ ... ] (array of jsons)
                "address" (string) the server host and port
                "connected" (string) "connected" accepts two possible values:
                    "inbound" or "outbound"
         */
        public string GetAddedNodeInfo(WebRequestPostExample httpInstance, Boolean dns, string node)
        {
            string json = httpInstance.CreateJsonRequest("getaddednodeinfo","[" + dns.ToString().ToLower() + "," + "\"" + node + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getconnectioncount method returns the number of connections
        to other nodes.
        :return: n (numeric) the connection count
         */
        public string GetConnectionCount(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getconnectioncount","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getdeprecationinfo method returns an object containing current
        version and deprecation block height.
        This method is applicable only to the KMD main net
        :return: JSON string containing:
            "version" (numeric)	the server version
            "subversion" (string) the server sub-version string
            "deprecationheight"	(numeric) the block height at which
                this version will deprecate and shut down
         */
        public string GetDeprecationInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getdeprecationinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getnettotals method returns information about network traffic,
        including bytes in, bytes out, and current time.
        :return: JSON string containing:
            "totalbytesrecv" (numeric) total bytes received
            "totalbytessent" (numeric) total bytes sent
            "timemillis" (numeric) total cpu time
         */
        public string GetNetTotals(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getnettotals","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getnetworkinfo method returns an object containing various state
        info regarding p2p networking.
        :return: JSON string with various state info regarding p2p networking.
         */
        public string GetNetworkInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getnetworkinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getpeerinfo method returns data about each connected network
        node as a json array of objects.
        :return: JSON string with data about each connected network node
            as a json array of objects.
         */
        public string GetPeerInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getpeerinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The listbanned method lists all banned IP addresses and subnets
        :return: JSON string containing:
            "address" (string) the address/subnet that is banned
            "banned_until" (numeric) the timestamp, at which point the ban
                will be removed
         */
        public string ListBanned(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("listbanned","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The ping method requests that a ping be sent to all other nodes,
        to measure ping time.
        :return: JSON string
         */

        public string Ping(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("ping","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
        
        /*
        The setban method attempts to add or remove an IP address
        (and subnet, if indicated) from the banned list
        :param ip: (string, ip required) the IP/subnet with an optional
            netmask (default is /32 = single ip)
        :param command: (string, required)	use "add" to add an IP/subnet
            to the list, or "remove" to remove an IP/subnet from the list
        :param bantime: (numeric, optional)	indicates how long (in seconds)
            the ip is banned (or until when, if [absolute] is set). 0 or
            empty means the ban is using the default time of 24h.
        :param absolute: (boolean, optional) if set to true, the bantime
            must be an absolute timestamp (in seconds)
            since epoch (Jan 1 1970 GMT)
        :return: JSON string
         */
        public string SetBan(WebRequestPostExample httpInstance,string ip, string command, int bantime, Boolean absolute)
        {
            string json = httpInstance.CreateJsonRequest("setban","[" +"\"" + ip + "\"" + "," + "\"" + command + "\"" + "," + bantime.ToString() + "," + absolute.ToString().ToLower() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

    }
}