using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
          /*
        RAW TRANSACTION COMMANDS
         */

        /*
        The createrawtransaction method creates a transaction, spending
        the given inputs and sending to the given addresses.
        :param transactions: {string, number} a dictinary of txid (string)
            as key and vout (number) as value.
        :param amounts: {string, number} a dictinary of address (string)
            as key and amount (number) as value.
        :return: "transaction" (JSON string) a hex string of the transaction
         */
        public string CreateRawTransaction(WebRequestPostExample httpInstance, Dictionary<String,Double> transactions, Dictionary<String,Double> amounts)
        {
            string tx_list = "[";
            foreach(var transaction in transactions)
            {
                tx_list = tx_list + "{" + "\"txid" + "\"" + ":" + "\"" + transaction.Key + "\"" + "," + "\"" + "vout\"" + ":" + transaction.Value.ToString() + "}]";
            }
            if(tx_list.Length > 1)
                {
                    tx_list = tx_list.Substring(0, (tx_list.Length - 1 ) );
                }

            tx_list = tx_list + "]";

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
            
            string json = httpInstance.CreateJsonRequest("createrawtransaction","[" + tx_list + "," + amount_list +  "]" );
            string result = CallHttpRequest(json);
            return result;


        }

        /*
         The decoderawtransaction method returns a json object representing
        the serialized, hex-encoded transaction.
        :param hexstring: (string, required) the transaction hex string.
        :return: JSON string with the serialized, hex-encoded transaction.
         */
        public string DecodeRawTransaction(WebRequestPostExample httpInstance, string hexstring)
        {
            string json = httpInstance.CreateJsonRequest("decoderawtransaction","[" + "\"" + hexstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The decodescript method decodes a hex-encoded script.
        :param hexstring: (string)	the hex encoded script
        :return: JSON string containing:
            "asm" (string) the script public key
            "hex" (string) the hex-encoded public key
            "type" (string) the output type
            "reqSigs" (numeric) the required signatures
            "addresses" [ ... ] (array of strings)
            "address" (string) the address
            "p2sh" (string) the script address
         */
        public string DecodeScript(WebRequestPostExample httpInstance, string hexstring)
        {
            string json = httpInstance.CreateJsonRequest("decodescript","[" + "\"" + hexstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The fundrawtransaction method adds inputs to a transaction
        until it has enough in value to meet its out value.
        :param hexstring: (string, required) the hex string of the
            raw transaction
        :return: JSON string containing:
            "hex" (string) the resulting raw transaction
                (hex-encoded string)
            "fee" (numeric)	the fee added to the transaction
            "changepos"	(numeric) the position of the added change
                output, or -1
         */
        public string FundRawTransaction(WebRequestPostExample httpInstance, string hexstring)
        {
            string json = httpInstance.CreateJsonRequest("fundrawtransaction","[" + "\"" + hexstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getrawtransaction method returns the raw transaction data.
        :param txid: (string, required) the transaction id
        :param verbose: (numeric, optional, default=0) if 0,
            the method returns a string in hex; otherwise, it returns
            a json object
        :return: "data"	(JSON string) if verbose is not set, or set to 0,
            the serialized, hex-encoded data for 'txid'
         */
        public string GetRawTransaction(WebRequestPostExample httpInstance, string txid, int verbose)
        {
            string json = httpInstance.CreateJsonRequest("getrawtransaction","[" + "\"" + txid + "\"" + "," + verbose.ToString()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The sendrawtransction method submits raw transaction
        (serialized, hex-encoded) to local nodes and the network.
        :param hexstring: (string, required) the hex string of the
            raw transaction
        :param allowhighfees: (boolean, optional, default=false)
            whether to allow high fees
        :return: "hex" (JSON string) the transaction hash in hex
         */
        public string SendRawTransaction(WebRequestPostExample httpInstance, string hexstring, Boolean allow_high_fees)
        {
            string json = httpInstance.CreateJsonRequest("sendrawtransaction","[" + "\"" + hexstring + "\"" + "," + allow_high_fees.ToString().ToLower() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The signrawtransaction method signs inputs for a raw transaction
        (serialized, hex-encoded).
        :param hexstring: (string, required) the transaction hex string
        :return: JSON string containing:
            "hex" (string) the hex-encoded raw transaction with signature(s)
            "complete" (boolean) whether the transaction has a complete set
                of signatures
            "errors"
            "txid" (string) the hash of the referenced, previous transaction
            "vout" (numeric) the index of the output to spend and used as input
            "scriptSig"	(string) the hex-encoded signature script
            "sequence" (numeric) the script sequence number
            "error" (string) verification or signing error related to the input
         */
         public string SignRawTransaction(WebRequestPostExample httpInstance, string hexstring)
        {
            string json = httpInstance.CreateJsonRequest("signrawtransaction","[" + "\"" + hexstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}