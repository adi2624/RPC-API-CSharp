using System;
using System.Collections.Generic;

namespace Blockchain
{


    public partial class WebRequestPostExample
    {
            /*

            ADDRESS COMMANDS

            */

            /*
            The getaddressbalance method returns the confirmed balance for
            an address, or addresses. It requires addressindex to be enabled
            :param addresses: [string]	a list of addresses
            :return: JSON string containing:
                "balance" (number) the current confirmed balance in satoshis
                "received" (number) the total confirmed number of satoshis
                    received (including change)
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

            /*
                The getaddressdeltas method returns all confirmed balance
                changes of an address.
                :param addresses: [string] a list of addresses
                :param start: (number) the start block height
                :param end: (number) the end block height
                :param chainInfo:(boolean) include chain info in results
                    (only applies if start and end specified)
                :return: JSON string containing:
                    "satoshis" (number) the difference in satoshis
                    "txid" (string) the related transaction id
                    "index"	(number) the related input or output index
                    "height" (number) the block height
                    "address" (string) the address
             */


            /*
            
             */
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

            /*
            The getaddressmempool method returns all mempool deltas for an
            address, or addresses. It requires addressindex to be enabled.
            :param addresses: [string] a list of addresses
            :return: JSON string containing:
                "address" (string) the address
                "txid" (string)	the related txid
                "index"	(number) the related input or output index
                "satoshis"	(number) the difference in satoshis
                "timestamp"	(number) the time the transaction entered the
                    mempool (seconds)
                "prevtxid" (string) the previous txid (if spending)
                "prevout" (string) the previous transaction output index
                    (if spending)
             */
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

            /*
            The getaddresstxids method returns the txids for an address,
            or addresses. It requires addressindex to be enabled.
            :param addresses: [string] a list of addreses
            :param start: (number)	the start block height
            :param end: (number)	the end block height
            :return: "transaction_id" (JSON string) the transaction id
             */

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

            /*
             The getaddressutxos method returns all unspent outputs for
            an address. It requires addressindex to be enabled.
            :param addresses: [string] a list of addreses
            :param chainInfo: (boolean)	include chain info with results
            :return: JSON string containing:
                "address" (string) the address
                "txid" (string) the output txid
                "height" (number) the block height
                "outputIndex" (number) the output index
                "script" (string) the script hex encoded
                "satoshis" (number) the number of satoshis of the output
             */
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

        /*
        The getsnapshot method returns a snapshot of addresses and their
        amounts at the asset chain's current height.
        The method requires addressindex to be enabled.
        :param top: (number, optional)	Only return this many addresses,
            i.e. top N rich lis
        :return: JSON string containing:
            "addresses"	(array of jsons) the array containing the address
                and amount details
            "addr" (string) an address
            "amount" (number) the amount of coins in the above address
            "total"	(numeric) the total amount in snapshot
            "average" (numeric)	the average amount in each address
            "utxos"	(number) the total number of UTXOs in snapshot
            "total_addresses" (number) the total number of addresses
                in snapshot.
            "start_height" (number) the block height snapshot began
            "ending_height"	(number) the block height snapshot finished,
            "start_time" (number) the unix epoch time snapshot started
            "end_time" (number) the unix epoch time snapshot finished
         */
            public string GetSnapshot(WebRequestPostExample httpInstance, int top)
            {
                string json = httpInstance.CreateJsonRequest("getsnapshot","[" + "\"top.ToString()\"" +  "]" );
                string result = CallHttpRequest(json);
                return result;
            }


    }
}