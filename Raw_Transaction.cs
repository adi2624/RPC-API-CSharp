using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
          /*
        RAW TRANSACTION COMMANDS
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

        public string DecodeRawTransaction(WebRequestPostExample httpInstance, string hexstring)
        {
            string json = httpInstance.CreateJsonRequest("decoderawtransaction","[" + "\"" + hexstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string DecodeScript(WebRequestPostExample httpInstance, string hexstring)
        {
            string json = httpInstance.CreateJsonRequest("decodescript","[" + "\"" + hexstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string FundRawTransaction(WebRequestPostExample httpInstance, string hexstring)
        {
            string json = httpInstance.CreateJsonRequest("fundrawtransaction","[" + "\"" + hexstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string GetRawTransaction(WebRequestPostExample httpInstance, string txid, int verbose)
        {
            string json = httpInstance.CreateJsonRequest("getrawtransaction","[" + "\"" + txid + "\"" + "," + verbose.ToString()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        public string SendRawTransaction(WebRequestPostExample httpInstance, string hexstring, Boolean allow_high_fees)
        {
            string json = httpInstance.CreateJsonRequest("sendrawtransaction","[" + "\"" + hexstring + "\"" + "," + allow_high_fees.ToString().ToLower() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

         public string SignRawTransaction(WebRequestPostExample httpInstance, string hexstring)
        {
            string json = httpInstance.CreateJsonRequest("signrawtransaction","[" + "\"" + hexstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}