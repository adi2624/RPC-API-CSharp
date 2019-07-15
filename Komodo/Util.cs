using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         /*
        UTIL COMMANDS
         */

        /*
        The createmultisig method creates a multi-signature address with
        n signature(s) of m key(s) required.
        :param number_required: (numeric, required)	the number of required
            signatures out of the n key(s) or address(es)
        :param keys: [string, required]	a list of keys (string) which are
            addresses or hex-encoded public keys
        :return: JSON string containing:
            "address" (string) the value of the new multisig address
            "redeemScript" (string)	the string value of the hex-encoded
                redemption script
         */
        public string CreateMultiSig(WebRequestPostExample httpInstance, int number_required, List<String> keys)
        {
            String key_list = "[";
                foreach(var key_individual in keys)
                    {
                        key_list = key_list + "\"" + key_individual + "\"" + ",";
                    }
                if(key_list.Length > 1)
                    {
                        key_list = key_list.Substring(0, (key_list.Length - 1 ) );
                    }

                key_list = key_list + "]";

                    string json = httpInstance.CreateJsonRequest("createmultisig","[" + number_required.ToString() + "," + key_list + "]" );
                    string result = CallHttpRequest(json);
                    return result;
        }

        /*
         The decodeccopret method decodes the OP RETURN data from
        a CC transaction to output the EVALCODE and function id of
        the method that produced the transaction.
        :param scriptPubKey: (string) the hex-string format scriptPubKey
            of the type : nulldata in the vout of a transaction produced
            by a CC module
        :return: JSON string containing:
            result (string) whether the call succeeded
            OpRets (json) a json containing the keys EVALCODE and function id
            eval_code (hexadecimal number) the EVALCODE of the method that
                produced the transaction.
            function (string) the function id of the method that produced the
                transaction.
         */
        public string DecodeCCopret(WebRequestPostExample httpInstance,string script_pub_key)
        {
            string json = httpInstance.CreateJsonRequest("decodeccopret","[" + "\"" + script_pub_key + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The estimatefee method estimates the approximate fee per kilobyte.
        The method is needed for a transaction to begin confirmation within
        nblocks blocks. The value -1.0 is returned if not enough transactions
        and blocks have been observed to make an estimate.
        :param num_blocks: (numeric) the number of blocks within which
            the fee should be tested
        :return: number (JSON string) the estimated fee
         */
        public string EstimateFee(WebRequestPostExample httpInstance, int num_blocks)
        {
            string json = httpInstance.CreateJsonRequest("estimatefee","["  + num_blocks.ToString()  +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The estimatepriority method estimates the approximate priority of
        a zero-fee transaction, when it needs to begin confirmation within
        nblocks blocks. The value -1.0 is returned if not enough transactions
        and blocks have been observed to make an estimate
        :param num_blocks: (numeric) a statement indicating within how many
            blocks the transaction should be confirmed
        :return: number	(numeric) the estimated priority
         */
        public string EstimatePriority(WebRequestPostExample httpInstance, int num_blocks)
        {
            string json = httpInstance.CreateJsonRequest("estimatepriority","["  + num_blocks.ToString()  +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The invalidateblock method permanently marks a block as invalid,
        as if it violated a consensus rule.
        :param block_hash: (string, required) the hash of the block to
            mark as invalid
        :return: JSON string
         */
        public string InvalidateBlock(WebRequestPostExample httpInstance, string block_hash)
        {
            string json = httpInstance.CreateJsonRequest("invalidateblock","["  +  "\"" + block_hash + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The reconsiderblock method removes invalidity status of a block
        and its descendants, reconsidering them for activation.
        :param block_hash: (string, required) the hash of the block
            to reconsider
        :return: JSON string
         */

         public string ReconsiderBlock(WebRequestPostExample httpInstance, string block_hash)
        {
            string json = httpInstance.CreateJsonRequest("reconsiderblock","["  +  "\"" + block_hash + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The txnotarizedconfirmed method returns information about
        a transaction's state of confirmation.
        :param tx_id: (string, required) the transaction id
        :return: "result" (JSON string) whether the transaction is
            confirmed, for dPoW-based chains;
         */
        public string TxNotarizeConfirmed(WebRequestPostExample httpInstance, string tx_id)
        {
            string json = httpInstance.CreateJsonRequest("txnotarizedconfirmed","["  +  "\"" + tx_id + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The validateaddress method returns information about the given address.
        :param address: (string, required) the address to validate
        :return: JSON string containing:
            "isvalid" (boolean) indicates whether the address is valid.
                If it is not, this is the only property returned.
            "address" (string) the address validated
            "scriptPubKey" (string) the hex encoded scriptPubKey generated by
                the address
            "ismine" (boolean) indicates whether the address is yours
            "isscript" (boolean) whether the key is a script
            "pubkey" (string) the hex value of the raw public key
            "iscompressed" (boolean) whether the address is compressed
            "account" (string) DEPRECATED the account associated with the
                address; "" is the default account
         */
        public string ValidateAddress(WebRequestPostExample httpInstance, string address)
        {
            string json = httpInstance.CreateJsonRequest("validateaddress","["  +  "\"" + address + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The verifymessage method verifies a signed message.
        :param address: (string, required) the address to use for
            the signature
        :param signature: (string, required) the signature provided
            by the signer in base 64 encoding
        :param message: (string, required)	the message that was signed
        :return: true/false	(JSON string) indicates whether the signature
            is verified
         */
        public string VerifyMessage(WebRequestPostExample httpInstance, string address, string signature, string message)
        {
            string json = httpInstance.CreateJsonRequest("verifymessage","["  +  "\"" + address + "\"" + "," + "\"" + signature + "\"" + "," + "\"" + message + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_validateaddress method returns information about
        the given z address.
        :param address: "zaddr"	(string, required) the z address
            to validate
        :return: JSON string containing:
            "isvalid" (boolean) indicates whether the address is valid;
                if not, this is the only property returned
            "address" (string) the z address validated
            "ismine" (boolean) indicates if the address is yours or not
            "payingkey" (string) the hex value of the paying key, a_pk
            "transmissionkey" (string) the hex value of the transmission
                key, pk_enc
         */
        public string Z_ValidateAddress(WebRequestPostExample httpInstance, string address)
        {
            string json = httpInstance.CreateJsonRequest("z_validateaddress","["  +  "\"" + address + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }


    }
}