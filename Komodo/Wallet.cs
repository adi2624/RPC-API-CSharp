using System;
using System.Collections.Generic;

namespace Blockchain
{

public partial class WebRequestPostExample
{
     /*
        WALLET COMMANDS
         */

        
        /*
        The getwalletinfo method returns an object containing various
        information about the wallet state.
        :return: JSON string:
                "walletversion" (numeric) the wallet version
                "balance" (numeric) the total confirmed balance of the wallet
                "unconfirmed_balance" (numeric) the total unconfirmed
                    balance of the wallet
                "immature_balance" (numeric) the total immature balance
                    of the wallet
                "txcount" (numeric) the total number of transactions
                    in the wallet
                "keypoololdest" (numeric) the timestamp (seconds since GMT
                    epoch) of the oldest pre-generated key in the key pool
                "keypoolsize" (numeric) how many new keys are pre-generated
                "unlocked_until" (numeric) the timestamp in seconds since
                    epoch (midnight Jan 1 1970 GMT) that the wallet is
                    unlocked for transfers, or 0 if the wallet is locked
                "paytxfee" (numeric) the transaction fee configuration,
                    given as the relevant COIN per KB
         */
        public string GetWalletInfo(WebRequestPostExample httpInstance)
            {
                
                //string json = "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"getwalletinfo\", \"params\": [] }";
                string json = httpInstance.CreateJsonRequest("getwalletinfo","[]");
                string result = CallHttpRequest(json);
                return result;
            }
        
        /*
         The backupwallet method safely copies the wallet.dat file
        to the indicated destination.
        This method requires that the coin daemon have the exportdir
        runtime parameter enabled.
        :param "destination" (string, required) the destination filename,
            saved in the directory set by the exportdir runtime parameter
        :return: "path" (JSON string) the full path of the destination file
         */
        public string BackupWallet(WebRequestPostExample httpInstance,string filename)
        {
            
            //string json_request_data = "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"backupwallet\", \"params\": [\""+filename+"\"] }";
            string json_request_data = httpInstance.CreateJsonRequest("backupwallet","[" + "\"" + filename + "\"" + "]");
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The dumpprivkey method reveals the private key corresponding
        to the indicated address.
        :param "address" (string, required) the address for the private key
        :return: "data" (JSON string) the private key
         */
        public string DumpPrivKey(WebRequestPostExample httpInstance, string address)
        {
            string json_request_data = httpInstance.CreateJsonRequest("dumpprivkey", "[" + "\"" +address + "\"" + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The dumpwallet method dumps all transparent-address wallet keys
        into a file, using a human-readable format.
        :param: "filename" (string, required) the filename, saved in the
            folder set by the exportdir runtime parameter.
        :return: "path" (JSON string) the full path of the destination file
         */
        public string DumpWallet(WebRequestPostExample httpInstance,string filename)
            {
                //string json_request_data = "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"dumpwallet\", \"params\": [\"" + filename + "\"] }";
                string json_request_data = httpInstance.CreateJsonRequest("dumpwallet", "[" + "\"" + filename + "\"" + "]" );
                string result = CallHttpRequest(json_request_data);
                return result;

            }
            
        /*
        The encryptwallet method encrypts the wallet with the
        indicated passphrase.
        :param passphrase (string) the passphrase for wallet encryption;
            the passphrase must be at least 1 character, but should be many
        :return: (JSON String) wallet encrypted; Komodo server stopping,
            restart to run with encrypted wallet. The keypool has been flushed,
            you need to make a new backup.
         */
        public string EncryptWallet(WebRequestPostExample httpInstance, string passphrase)
        {
            string json_request_data = httpInstance.CreateJsonRequest("encryptwallet", "["  + "\"" + passphrase  + "\"" + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The getaccount method returns the account associated with
        the given address.
        :param address (string, required) the address
        :return: "accountname" (JSON string) the account address
         */
        public string GetAccount(WebRequestPostExample httpInstance, string address)
        {
           
            //string json_request_data = "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"getaccount\", \"params\": [\"" + address + "\"] }";
            string json_request_data = httpInstance.CreateJsonRequest("getaccount", "[" + "\"" + address + "\"" + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The getbalance method returns the server's total available balance.
        The account input is deprecated.
        :param account (string, optional) DEPRECATED if provided, it MUST be
            set to the empty string "" or to the string "*"
        :param minconf (numeric, optional, default=1) only include
            transactions confirmed at least this many times
        :param includeWatchOnly:(bool, optional, default=false)	also include
            balance in watchonly addresses
        :return: amount	(JSON string)	the total amount
         */
        public string GetBalance(WebRequestPostExample httpInstance, string account, int minconf, Boolean includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getbalance", "[" + "\""  + "\"" + "," + minconf.ToString() + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
         The getnewaddress method returns a new address for receiving payments
        :param account (string, optional) DEPRECATED: If provided, the account
            MUST be set to the empty string "" to represent the default account
        :return: "address" (JSON string) the new address
         */
        public string GetNewAddress(WebRequestPostExample httpInstance, string account)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getnewaddress", "[" +  "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

       
        public string DumpPrivateKey(WebRequestPostExample httpInstance, string address)
        {
            string json_request_data = httpInstance.CreateJsonRequest("dumpprivkey", "[" + "\"" + address + "\"" + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

         /*
        The getrawchangeaddress returns a new address that can be used
        to receive change.
        :return: "address" (JSON string) the address
         */
        public string GetRawChangeAddress(WebRequestPostExample httpInstance)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getrawchangeaddress","[]");
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The getreceivedbyaddress method returns the total amount received
        by the given address in transactions with at least minconf confirmations
        :param address (string, required) the address for transactions
        :param minconf (numeric, optional, default=1) only include
            transactions confirmed at least this many times
        :return: amount	(JSON string) the total amount of the relevant coin
            received at this address
         */
        public string GetReceivedByAddress(WebRequestPostExample httpInstance, string address, string minconf)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getreceivedbyaddress","[" +  "\""+ address + "\"" + ","  + minconf   + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
            The gettransaction method queries detailed information about
            transaction txid. This command applies only to txid's that are in
            the user's local wallet
            :param txid: (string, required)	the transaction id
            :param includeWatchOnly: (bool, optional, default=false) whether to
                include watchonly addresses in the returned balance calculation and
                in the details[] returned values
            :return: JSON string with transaction details
         */
        public string GetTransaction(WebRequestPostExample httpInstance, string txid, string includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("getreceivedbyaddress","[" +  "\""+ txid + "\"" + ","  +  "\"" +  includeWatchOnly +  "\""  + "]" );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The getunconfirmedbalance method returns the server's total
        unconfirmed balance
        :return: JSON string
         */

        public string GetUnconfirmedBalance(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getunconfirmedbalance","[]");
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The importaddress method adds an address or script (in hex) that
        can be watched as if it were in your wallet, although it cannot be
        used to spend. This call can take an increased amount of time to
        complete if rescan is true.
        :param address:(string, required) the address to watch
        :param label:(string, optional, default="")	an optional label
        :param rescan: (boolean, optional, default=true) rescan the
            wallet for transactions
        :return: JSON string
         */
        public string ImportAddress(WebRequestPostExample httpInstance, string address, string label, string rescan)
        {
            string json = httpInstance.CreateJsonRequest("importaddress", "[" +  "\""+ address + "\"" + ","  +  "\"" +  label +  "\""  + ","  + rescan.ToLower()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The importprivkey method adds a private key to your wallet.
        :param privKey: (string, required) the private key
        :param label: (string, optional, default="") an optional label
        :param rescan: (boolean, optional, default=true) rescan the wallet
            for transactions
        :return: addresses (JSON string) the public address
         */
        public string ImportPrivKey(WebRequestPostExample httpInstance, string priv_key, string label, Boolean rescan)
        {
            string json = httpInstance.CreateJsonRequest("importprivkey", "[" +  "\""+ priv_key + "\"" + ","  +  "\"" +  label +  "\""  + ","  + rescan.ToString().ToLower()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        
        The importwallet method imports transparent-address keys from
        a wallet-dump file
        :param path:(string, required) the wallet file
        :return:JSON string

         */
        public string ImportWallet(WebRequestPostExample httpInstance, string path)
        {
            string json_request_data = httpInstance.CreateJsonRequest("importwallet", "[" + "\"" + path + "\"" + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The keypoolrefill method refills the keypool
        :param newsize:(numeric, optional, default=100)	the new keypool size
        :return:JSON string
         */

        public string KeyPoolRefill(WebRequestPostExample httpInstance, int newsize)
        {
            string json_request_data = httpInstance.CreateJsonRequest("keypoolrefill", "["  + newsize.ToString() + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        
        The listaddressgroupings method lists groups of addresses which
        have had their common ownership made public by common use as inputs
        or as the resulting change in past transactions
        :return: JSON string
            "address" (string) the address
            amount (numeric) the amount
            "account" (string, optional) (DEPRECATED) the account
         */
        public string ListAddressGroupings(WebRequestPostExample httpInstance)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listaddressgroupings", "["  + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The listlockunspent method returns a list of temporarily
        non-spendable outputs
        :return: JSON string
            "txid" (string)	the transaction id locked
            "vout" (numeric) the vout value


         */
        public string ListLockUnspent(WebRequestPostExample httpInstance)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listlockunspent", "["  + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        
        The listreceivedbyaddress method lists balances by receiving address
        :param minconf:(numeric, optional, default=1) the minimum number of
            confirmations before payments are included
        :param includeEmpty:(numeric, optional, default=false) whether to
            include addresses that haven't received any payments
        :param includeWatchOnly:(bool, optional, default=false)	whether to
            include watchonly addresses (see 'importaddress')
        :return:JSON string:
            "involvesWatchonly"	(bool) only returned if imported addresses were
                involved in transaction
            "address" (string) the receiving address
            "account" (string) DEPRECATED the account of the receiving address;
                the default account is ""
            "amount" (numeric) the total amount received by the address
            "confirmations"	(numeric) a confirmation number that is dPoW aware;
            "rawconfirmations" (numeric) the raw confirmations of the most
                recent transaction included (number of blocks on top of this
                transaction's block)
         */
        public string ListReceivedByAddress(WebRequestPostExample httpInstance,int minconf,Boolean includeEmpty, Boolean includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listreceivedbyaddress", "["  + minconf.ToString() + "," + includeEmpty.ToString().ToLower() + "," + includeWatchOnly.ToString().ToLower() + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
            The listsinceblock method queries all transactions in blocks since
        block blockhash, or all transactions if blockhash is omitted
        :param blockhash: (string, optional) the block hash from which
            to list transactions
        :param targetconf: (numeric, optional) the confirmations required
            (must be 1 or more)
        :param includeWatchOnly: (bool, optional, default=false) include
            transactions to watchonly addresses
        :return: JSON string with block details
         */

        public string ListsInCeBlock(WebRequestPostExample httpInstance, string blockhash, int targetconf, Boolean includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listsinceblock", "["  + "\"" + blockhash + "\""  + "," + targetconf.ToString() + "," + includeWatchOnly.ToString().ToLower() + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The listtransactions method returns up to count most recent
        transactions skipping the first from transactions for account.
        :param account: (string, optional)	DEPRECATED the account name;
            should be "*"
        :param count:(numeric, optional, default=10) the number of
            transactions to return
        :param skip: (numeric, optional, default=0)	the number of
            transactions to skip
        :param includeWatchOnly: (bool, optional, default=false) include
            transactions to watchonly addresses
        :return: JSON string with transactin details
         */
        public string ListTransactions(WebRequestPostExample httpInstance,string account, int count, int skip, Boolean includeWatchOnly)
        {
            string json_request_data = httpInstance.CreateJsonRequest("listtransactions", "["  + "\"" + "*" + "\""  + "," + count.ToString() + "," + skip.ToString() + "," + includeWatchOnly.ToString().ToLower() + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
        The listunspent method returns an array of unspent transaction
        outputs, with a range between minconf and maxconf (inclusive)
        confirmations.
        :param minconf:(numeric, optional, default=1) the minimum
            confirmations to filter
        :param maxconf:(numeric, optional, default=9999999)	the maximum
            confirmations to filter
        :param addresses:(string) a series of addresses
        :return: JSON string:
            "txid" (string) the transaction id
            "vout" (numeric) the vout value
            "generated"	(boolean) true if txout is a coinbase transaction
                output
            "address" (string) the address
            "account" (string) DEPRECATED the associated account, or "" for
                the default account
            "scriptPubKey" (string) the script key
            "amount" (numeric) the transaction amount
            "confirmations"	(numeric) a confirmation number that is dPoW aware
            "rawconfirmations" (numeric) the raw confirmations (number of
                blocks on top of this transaction's block)
         */
        public string ListUnspent(WebRequestPostExample httpInstance,int minconf,int maxconf,List<String> addresses)
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

            string json = httpInstance.CreateJsonRequest("listunspent","[" +  minconf.ToString() + ","  + maxconf.ToString() + "," + addr_list + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The lockunspent method locks (unlock = false) or unlocks
        (unlock = true) specified transaction outputs.
        :param unlock:(boolean, required)	whether to unlock (true)
            or lock (false) the specified transactions
        :param txid:(string) the transaction id
        :param vout:(numeric) the output number
        :return: true/false	(JSON string) whether the command was successful
         */
        public string LockUnspent(WebRequestPostExample httpInstance, Boolean unlock, string txid, int vout)
        {
            string json = httpInstance.CreateJsonRequest("lockunspent","["  + unlock.ToString().ToLower() + "," + "[{" + "\"txid\":"  + "\"" + txid  + "\""  + "," + "\"vout"  + "\"" +  ":" + vout  + "}]]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The resendwallettransactions method immediately re-broadcasts
        unconfirmed wallet transactions to all peers.
        :return: "transaction_id" (JSON string) an array of the rebroadcasted
            transaction id's
         */
        public string ResendWalletTransactions(WebRequestPostExample httpInstance)
        {
            string json_request_data = httpInstance.CreateJsonRequest("resendwallettransactions", "["  + "]"  );
            string result = CallHttpRequest(json_request_data);
            return result;
        }

        /*
         The sendmany method can send multiple transactions at once.
        Amounts are double-precision floating point numbers
        :param account:(string, required) MUST be set to the
            empty string "" to represent the default account;
            passing any other string will result in an error
        :param amounts:{"string":numeric} dictionary with the address (string)
            and the value (double-precision floating numeric)
        :param minconf:(numeric, optional, default=1) only use the balance
            confirmed at least this many times
        :param comment: (string, optional) a string comment
        :param subtractFeeFromAmt: [string, optional] (string, optional) a
            string list with addresses. The fee will be equally deducted
            from the amount of each selected address; the recipients will
            receive less than you enter in their corresponding amount field.
        :return: "transaction_id" (JSON string) the transaction id for the send;
            only 1 transaction is created regardless of the number of addresses
         */
        public string SendMany(WebRequestPostExample httpInstance, Dictionary<String,Double> amounts, int minconf, string comment, List<String> subtract_fee)
        {
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

            string subtract_list = "[";
            foreach(var fee_individual in subtract_fee)
            {
                subtract_list = subtract_list + "\"" + fee_individual + "\"" + ",";
            }
            
            if(subtract_list.Length > 1)
                {
                    subtract_list = subtract_list.Substring(0, (subtract_list.Length - 1 ) );
                }

            subtract_list = subtract_list + "]";

            string json = httpInstance.CreateJsonRequest("sendmany","[" +  "\"" + "\"" + ","  + amount_list + "," + minconf.ToString() +"," + "\"" + comment.ToString() + "\"" + "," + subtract_list + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The sendtoaddress method sends an amount to a given address.
        The amount is real and is rounded to the nearest 0.00000001
        :param address: (string, required)	the receiving address
        :param amount: (numeric, required) the amount to send (json requires
            all decimals values less than 1 begin with the characters '0.')
        :param comment: (string, optional)	a comment used to store what the
            transaction is for; this is not part of the transaction,
            just kept in your wallet
        :param comment_to: (string, optional) a comment to store the name
            of the person or organization to which you're sending the
            transaction; this is stored in your local wallet file only
        :param subtractFeeFromAmt: (boolean, optional, default=false)
            when true, the fee will be deducted from the amount being sent
        :return: "transaction_id" (JSON string) the transaction id
         */
        public string SendToAddress(WebRequestPostExample httpInstance, string address, Double amount, string comment, string comment_to, Boolean subtract_amount_from_fee)
        {
            string json = httpInstance.CreateJsonRequest("sendtoaddress","[" +  "\"" + address + "\"" + "," + amount.ToString() +"," + "\"" + comment + "\"" + "," + "\"" + comment_to + "\"" + "," + subtract_amount_from_fee.ToString().ToLower() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The setpubkey method sets the indicated pubkey. This method
        can be used in place of the pubkey launch parameter, when necessary.
        :param pubKey:(string) the desired pubkey
        :return: JSON string:
            pubkey (string) the pubkey
            ismine (boolean) indicates whether the address belongs to the user
            R-address (string) the public address associated with the pubkey
         */
        public string SetPubKey(WebRequestPostExample httpInstance, string pubkey)
        {
            string json = httpInstance.CreateJsonRequest("setpubkey","[" + "\"" +  pubkey + "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        
            The settxfee method sets the transaction fee per kB
        :param amount: (numeric, required) the transaction fee in COIN/kB
            rounded to the nearest 0.00000001
        :return: true/false	(JSON string) returns true if successful

         */
        public string SetTxFee(WebRequestPostExample httpInstance,Double amount)
        {
            string json = httpInstance.CreateJsonRequest("settxfee","["  +  amount.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The signmessage method signs a message via the private key of
        an address.
        :param address: (string, required) the address to use for the
            private key
        :param message:(string, required) the message
        :return: "signature" (JSON string) the signature of the message encoded
            in base 64
         */
        public string SignMessage(WebRequestPostExample httpInstance, string address, string message)
        {
            string json = httpInstance.CreateJsonRequest("signmessage","[" + "\"" +  address+ "\"" + "," + "\"" + message + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The walletlock method re-locks a wallet that has a passphrase
        enabled via encryptwallet.
        :return: JSON string
         */
        public string WalletLock(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("walletlock","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The walletpassphrase method unlocks the wallet using the passphrase
        that was set by the encryptwallet method.
        :param passphrase: (string)	the passphrase that was set by the
            encryptwallet method
        :param timeout:(number in seconds, optional) the amount of time for
            which the wallet should remember the passphrase
        :return: JSON string
         */
        public string WalletPassphrase(WebRequestPostExample httpInstance, string passphrase, int timeout)
        {
            string json = httpInstance.CreateJsonRequest("walletpassphrase","[" + "\"" +  passphrase + "\"" + "," + timeout.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The walletpassphrasechange method changes "oldpassphrase" to
        "newpassphrase".
        :param oldpassphrase:(string) the old passphrase
        :param newpassphrase:(string) the new passphrase
        :return: JSON string
         */
        public string WalletPassphraseChange(WebRequestPostExample httpInstance, string oldpassphrase, string newpassphrase)
        {
            string json = httpInstance.CreateJsonRequest("walletpassphrasechange","[" + "\"" +  oldpassphrase + "\"" + "," + "\"" + newpassphrase + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_exportkey method reveals the private z_key
        corresponding to z_address
        :param z_address:(string, required)	the z_address
            for the private key
        :return: "key" (JSON string) the private key
        '''
        data = '{'+rpc.get_request_metadata()+', ' \
                    '"method": "z_exportkey", ' \
                    '"params": ["'+str(z_address)+'"] }'

         */
        public string Z_ExportKey(WebRequestPostExample httpInstance, string z_address)
        {
            string json = httpInstance.CreateJsonRequest("z_exportkey","[" + "\"" +  z_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The z_exportviewingkey method reveals the viewing key
        corresponding to z_address
        :param z_address: (string, required) the z_address for the viewing key
        :return: "vkey"	(JSON string) the viewing key
         */
        public string Z_ExportViewingKey(WebRequestPostExample httpInstance, string z_address)
        {
            string json = httpInstance.CreateJsonRequest("z_exportviewingkey","[" + "\"" +  z_address + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The z_exportwallet method exports all wallet keys, including
        both t address and z address types, in a human-readable format.
        Overwriting an existing file is not permitted
        :param filename:(string, required)	the filename, saved to the
            directory indicated by the exportdir parameter at daemon runtime
        :return: "path"	(JSON string) the full path of the destination file
         */
        public string Z_ExportWallet(WebRequestPostExample httpInstance,string filename)
        {
            string json = httpInstance.CreateJsonRequest("z_exportwallet","[" + "\"" +  filename + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        
        The z_getbalance method returns the balance of a t address or
        z address belonging to the node’s wallet.
        :param address:(string)	the selected z or t address
        :param minconf: (numeric, optional, default=1)	only include
            transactions confirmed at least this many times
        :return: amount	(JSON numeric)	the total amount received at
            this address (in the relevant COIN value)
         */
        public string Z_GetBalance(WebRequestPostExample httpInstance, string address, int minconf)
        {
            string json = httpInstance.CreateJsonRequest("z_getbalance","[" + "\"" +  address + "\"" + "," + minconf.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_getnewaddress method returns a new z_address for receiving
        payments
        :return: "z_address" (JSON string) the new z_address
         */
        public string Z_GetNewAddress(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("z_getnewaddress","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_getoperationresult method retrieves the result and status
        of an operation which has finished, and then removes the operation
        from memory
        :param operationid: [string, optional]	a list of operation ids to
            query; if not provided, the method examines all operations
            known to the node
        :return: JSON String
            "id" (string) the operation id
            "status" (string) the result of the operation; can be success
            "creation_time" (numeric) the creation time, in seconds since
                epoch (Jan 1 1970 GMT)
            "result": { ... } (array of json objects)
            "txid":	(string) the transaction id
            "execution_secs" (numeric) the length of time to calculate the
                transaction
            "method" (string) the name of the method used in the operation
            "params": { ... } (json)
            "fromaddress" (string) the address from which funds are drawn
            "amounts": [ ... ]	(array of json objects)
            "address" (string) the receiving address
            "amount" (numeric) the amount to receive
            "minconf" (numeric)	the minimum number of confirmations required
            "fee" (numeric) the transaction fee
         */
        public string Z_GetOperationResult(WebRequestPostExample httpInstance, List<String> operation_id)
        {
            String op_list = "[";
            foreach(var op_individual in operation_id)
                {
                    op_list = op_list + "\"" + op_individual + "\"" + ",";
                }
            if(op_list.Length > 1)
                {
                    op_list = op_list.Substring(0, (op_list.Length - 1 ) );
                }

            op_list = op_list + "]";

            string json = httpInstance.CreateJsonRequest("z_getoperationresult","[" + op_list +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_getoperationstatus message queries the operation status
        and any associated result or error data of any operationid stored
        in local memory.
        :param operationid: [string, optional]	a list of operation-ids
            we are interested in; if an array is not provided, the method
            examines all operations known to the node
        :return: JSON string with operation details
         */
        public string Z_GetOperationStatus(WebRequestPostExample httpInstance, List<String> operation_id)
        {
             String op_list = "[";
            foreach(var op_individual in operation_id)
                {
                    op_list = op_list + "\"" + op_individual + "\"" + ",";
                }
            if(op_list.Length > 1)
                {
                    op_list = op_list.Substring(0, (op_list.Length - 1 ) );
                }

            op_list = op_list + "]";

            string json = httpInstance.CreateJsonRequest("z_getoperationstatus","[" + op_list +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_gettotalbalance method returns the total value of funds,
        including both transparent and private, stored in the node’s wallet
        :param minconf: (numeric, optional, default=1) only include private
            and transparent transactions confirmed at least this many times
        :param includeWatchOnly: (bool, optional, default=false) also include
            balance in watchonly addresses
        :return: JSON string:
            "transparent" (numeric) the total balance of transparent funds
            "interest" (numeric) the total balance of unclaimed interest
                earned
            "private" (numeric)	the total balance of private funds
            "total"	(numeric) the total balance of both transparent and
                private funds
         */
        public string Z_GetTotalBalance(WebRequestPostExample httpInstance, int minconf, Boolean includeWatchOnly)
        {
            string json = httpInstance.CreateJsonRequest("z_gettotalbalance","[" + minconf.ToString() + "," + includeWatchOnly.ToString().ToLower() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The z_importkey method imports z_privatekey to your wallet.
        This call can take minutes to complete if rescan is true
        :param z_privatekey: (string, required)	the z_privatekey
        :param rescan: (string, optional, default="whenkeyisnew") rescan
            the wallet for transactions; can be yes
        :param startHeight: (numeric, optional, default=0) the block
            height at which to begin the rescan
        :return: JSON string
         */

        public string Z_ImportKey(WebRequestPostExample httpInstance, string z_privatekey, string rescan, int startheight)
        {
            string json = httpInstance.CreateJsonRequest("z_importkey","[" + "\"" + z_privatekey + "\"" + "," + "\"" + rescan + "\"" + "," + startheight.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_importviewingkey adds a viewing key to your wallet.
        This method allows you to view the balance in a z address that
        otherwise does not belong to your wallet.
        :param viewing_key: (string, required)	the viewing key
        :param rescan: (string, optional, default="whenkeyisnew") whether
            to rescan the wallet for transactions; can be "yes"
        :param startHeight: (numeric, optional, default=0) block height
            to start rescan
        :return: JSON string
         */
        public string Z_ImportViewingKey(WebRequestPostExample httpInstance,string viewing_key, string rescan, int startheight)
        {
            string json = httpInstance.CreateJsonRequest("z_importviewingkey","[" + "\"" + viewing_key + "\"" + "," + "\"" + rescan + "\"" + "," + startheight.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The z_importwallet method imports t address and z address keys
        from a wallet export file
        :param filename: (string, required) the wallet file
        :return: JSON String
         */
        public string Z_ImportWallet(WebRequestPostExample httpInstance, string filename)
        {
            string json = httpInstance.CreateJsonRequest("z_importwallet","[" + "\"" + filename + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        
         The z_listaddresses method returns the list of z addresses
        belonging to the wallet.
        :param includeWatchOnly: (bool, optional, default=false) also
            include watchonly addresses
        :return: "z_address" ( JSON string) a z address belonging
            to the wallet
         */
        public string Z_ListAddresses(WebRequestPostExample httpInstance,Boolean includeWatchOnly)
        {
            string json = httpInstance.CreateJsonRequest("z_listaddresses","[" + includeWatchOnly.ToString().ToLower() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        
        The z_listoperationids method returns the list of operation
        ids currently known to the wallet.
        :param status: (string, optional) filter result by the
            operation's state e.g. "success"
        :return: "operationid"	(JSON string) an operation id belonging
            to the wallet
         */
        public string Z_ListOperationIds(WebRequestPostExample httpInstance,string status)
        {
            string json = httpInstance.CreateJsonRequest("z_listoperationids","[" + "\"" + status + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The z_listreceivedbyaddress method returns a list of amounts
        received by a z address belonging to the node’s wallet.
        :param address: (string)	the private address.
        :param minconf: (numeric, optional, default=1)	only include
            transactions confirmed at least this many times
        :return: JSON string:
            txid (string) the transaction id
            amount (numeric) the amount of value in the note
            memo (string ) hexadecimal string representation of memo field
            "confirmations"	(numeric) a confirmation number that is
                dPoW aware;
            "rawconfirmations" (numeric) the raw confirmations
                (number of blocks on top of this transaction's block)
            jsindex	(sprout) (numeric, received only by sprout addresses)
                the joinsplit index
            jsoutindex (numeric, received only by sprout addresses)
                the output index of the joinsplit
            outindex (numeric, sapling)	the output index
            change (boolean) true if the address that received the note is also
                one of the sending addresses
         */
        public string Z_ListReceivedByAddress(WebRequestPostExample httpInstance, string address, int minconf)
        {
            string json = httpInstance.CreateJsonRequest("z_listreceivedbyaddress","[" + "\"" + address + "\"" + "," + minconf.ToString()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_listunspent method returns an array of unspent shielded notes
        :param minconf: (numeric, optional, default=1)	the minimum
            confirmations to filter
        :param maxconf: (numeric, optional, default=9999999) the maximum
            confirmations to filter
        :param includeWatchOnly: (bool, optional, default=false) whether
            to also include watchonly addresses
        :param addresses: [string] a list of z addresses (both Sprout and
            Sapling) to act as a filter; duplicate addresses are not allowed
        :return: JSON string

         */

        public string Z_ListUnspent(WebRequestPostExample httpInstance, int minconf, int maxconf, Boolean includeWatchOnly, List<String> addresses)
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

            string json = httpInstance.CreateJsonRequest("z_listunspent","[" +  minconf.ToString() + ","  + maxconf.ToString() + "," + includeWatchOnly.ToString().ToLower() + "," + addr_list + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The z_mergetoaddress method merges multiple utxos and notes into
        a single utxo or note.
        :param fromaddresses: [string, required] a list of z or t addresses
        :param toaddress: (string, required)	the t address or z address
            to receive the combined utxo
        :param fee: (numeric, optional, default=0.0001)	the fee amount to
            attach to this transaction
        :param transparent_limit: (numeric, optional, default=50) limit on
            the maximum number of transparent utxos to merge; you may set
            this value to 0 to use the node option mempooltxinputlimit
        :param shielded_limit: (numeric, optional, default=10)	limit on
            the maximum number of hidden notes to merge; you may set this
            value to 0 to merge as many as will fit in the transaction
        :param memo: (string, optional)	encoded as hex; when toaddress is
            a z address, this value will be stored in the memo field of the
            new note
        :return: JSON string:
            "remainingUTXOs" (numeric) the number of utxos still
                available for merging
            "remainingTransparentValue" (numeric) the value of utxos still
                available for merging
            "remainingNotes" (numeric) the number of notes still available
                for merging
            "remainingShieldedValue" (numeric) the value of notes still
                available for merging
            "mergingUTXOs" (numeric) the number of utxos being merged
            "mergingTransparentValue" (numeric)	the value of utxos
                being merged
            "mergingNotes" (numeric) the number of notes being merged
            "mergingShieldedValue" (numeric) the value of notes being merged
            "opid" (string) an operationid to pass to z_getoperationstatus
                to get the result of the operation
        
         */
        public string Z_MergeToAddress(WebRequestPostExample httpInstance, List<String> from_addresses, string to_address, Double fee, int transparent_limit, int shielded_limit, string memo)
        {
            String addr_list = "[";
            foreach(var address_individual in from_addresses)
                {
                    addr_list = addr_list + "\"" + address_individual + "\"" + ",";
                }
            if(addr_list.Length > 1)
                {
                    addr_list = addr_list.Substring(0, (addr_list.Length - 1 ) );
                }

            addr_list = addr_list + "]";

            string json = httpInstance.CreateJsonRequest("z_mergetoaddress","[" + addr_list + "," + "\"" + to_address + "\"" + "," + (fee!=0.0001?fee.ToString():"\""+"\"") + "," + (transparent_limit!=50?transparent_limit.ToString():"\""+"\"") + "," + (shielded_limit!=10?shielded_limit.ToString():"\""+"\"") + (memo!=""?memo:"\""+"\"") + "]" );
            string result = CallHttpRequest(json);
            return result;
        }


        /*
        
            The z_sendmany method sends one or more transactions at once, and
        allows for sending transactions of types t --> t, t --> z, z --> z, z --> t.
        :param fromaddress: (string, required) the sending t address or
            z address
        :param amounts: {string : numeric}  a dictionary of z or t address
            as key and numeric amout value to be sent
        :param memo: (string, optional)	if the address is a z address, this
            property accepts raw data represented in hexadecimal string format
        :param minconf: (numeric, optional, default=1)	only use funds
            confirmed at least this many times
        :param fee: (numeric, optional, default=0.0001)	the fee amount to
            attach to this transaction
        :return: "operationid"	(string) an operationid to pass to
            z_getoperationstatus to get the result of the operation
         */
        public string Z_SendMany(WebRequestPostExample httpInstance,string fromaddress,Dictionary<String,Double> amounts, string memo, int minconf, Double fee)
        {
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

            string json = httpInstance.CreateJsonRequest("z_sendmany","[" + "\"" + fromaddress + "\"" + "," + amount_list + "," + (memo!=""?memo:"\""+"\"") + "," + (minconf!=1?minconf.ToString():"\""+"\"") + "," + (fee!=0.0001?fee.ToString():"\""+"\"") + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The z_shieldcoinbase method shields transparent coinbase funds by
        sending the funds to a shielded z address.
        :param fromaddress: (string, required)	the address is a t address
            or "*" for all t address belonging to the wallet
        :param toaddress: (string, required)	the address is a z address
        :param fee: (numeric, optional, default=0.0001)	the fee amount to
            attach to this transaction
        :param limit: (numeric, optional, default=50) limit on the maximum
            number of utxos to shield; set to 0 to use node option
            mempooltxinputlimit
        :return: JSON string:
            "remainingUTXOs" (numeric) the number of coinbase utxos still
                available for shielding
            "remainingValue" (numeric) the value of coinbase utxos still
                available for shielding
            "shieldingUTXOs" (numeric) the number of coinbase utxos
                being shielded
            "shieldingValue" (numeric) the value of coinbase utxos
                being shielded
            "opid" (string) an operationid to pass to z_getoperationstatus
                to get the result of the operation

         */
        public string Z_ShieldCoinBase(WebRequestPostExample httpInstance, string fromaddress, string to_address, double fee, int limit)
        {
            string json = httpInstance.CreateJsonRequest("z_shieldcoinbase","[" + "\"" + fromaddress + "\"" + "," + "\"" + to_address  +  "\"" + "," + (fee!=0.0001?fee.ToString():"\"" + "\"") + "," + (limit!=50?limit.ToString():"\"" + "\"")+ "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The zcbenchmark method runs a benchmark of the selected
        benchmarktype. This benchmark is calculated samplecount times.
        :param benchmarktype: (string, required) the type of the benchmark
        :param samplecount: (numeric) the number of samples to take
        :return: "runningtime" (numeric) the time it took to run the
            selected benchmarktype
         */
        public string ZCBenchmark(WebRequestPostExample httpInstance, string benchmark_type, int samplecount)
        {
            string json = httpInstance.CreateJsonRequest("zcbenchmark","[" + "\"" + benchmark_type + "\"" + "," + samplecount.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }
}

}