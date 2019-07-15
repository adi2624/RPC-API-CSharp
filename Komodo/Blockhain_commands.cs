using System;
using System.Collections.Generic;

namespace Blockchain
{


    public partial class WebRequestPostExample
    {
            /*

            BLOCKCHAIN COMMANDS

            */

        /*
        The coinsupply method returns the coin supply information for
        the indicated block height. If no height is given, the method
        defaults to the blockchain's current height.
        :param height: (integer, optional) the desired block height
        :return: JSON string containing:
            "result" (string) whether the request was successful
            "coin" (string) the ticker symbol of the coin for asset chains,
            "height" (integer) the height of this coin supply data
            "supply" (float) the transparent coin supply
            "zfunds" (float) the shielded coin supply (in zaddrs)
            "sprout" (float) the sprout coin supply (in zcaddrs)
            "total" (float) the total coin supply,
                i.e. sum of supply + zfunds
         */
        public string CoinSupply(WebRequestPostExample httpInstance, int height)
        {

            string json;

            if(height>1)
            {
                json = httpInstance.CreateJsonRequest("coinsupply","[" + "\"height.ToString()\"" +  "]" );
            }
            else
            {
                json = httpInstance.CreateJsonRequest("coinsupply","[" +  "]" );
            }

            string result = CallHttpRequest(json);
            return result;

        }

        /*
        The getbestblockhash method returns the hash of the best(tip) block
        in the longest block chain
        :return: "hex" (JSON string) the block hash, hex encoded
         */
        public string GetBestBlockHash(WebRequestPostExample httpInstance)
        {

            string json = httpInstance.CreateJsonRequest("getbestblockhash","["  +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getblock method returns the block's relevant state information
        :param block_id: (string OR number) block_id can be
            block-hash (string) OR block-height (number)
        :param verbose: (boolean, optional, default=true) true returns
            a json object, false returns hex-encoded data
        :return: JSON string containing:
            "hash" (string)	the block hash (same as provided hash)
            "confirmations" (numeric) a confirmation num that is dPoW aware
            "rawconfirmations" (numeric) the raw confirmations
                (number of blocks on top of this block); the returned value
                is -1 if the block is not on the main chain
            "size" (numeric) the block size
            "height" (numeric) the block height or index (same as provided
                height)
            "version" (numeric) the block version
            "merkleroot" (string) the merkle root
            "tx"  ["tx_id",...]	array of strings
            "time" (numeric) the block time in seconds since epoch
            "nonce" (numeric) the nonce
            "bits" (string) the bits
            "difficulty" (numeric) the difficulty
            "previousblockhash" (string) the hash of the previous block
            "nextblockhash" (string) the hash of the next block
         */

        
        public string GetBlock(WebRequestPostExample httpInstance, string block_id, Boolean verbose)
        {
            /*
            BLOCK ID CAN ONLY BE PASSED IN AS A STRING
             */

            string json = httpInstance.CreateJsonRequest("getblock","[" + "\"" + block_id + "\"" +  "," + verbose.ToString().ToLower() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getblockchaininfo method returns a json object containing state
        information about blockchain processing.
        :return: JSON string containing state information about blockchain
            processing.
         */
        public string GetBlockChainInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getblockchaininfo","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getblockcount method returns the number of blocks in the best
        valid block chain
        :return: data (JSON string) the current block count
         */
        public string GetBlockCount(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getblockcount","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }
        
        /*
        The getblockhash method returns the hash of the indicated block
        index, according to the best blockchain at the time provided.
        :param index: (numeric, required) the block index
        :return: "hash"	(JSON string) the block hash
         */
        public string GetBlockHash(WebRequestPostExample httpInstance, int index)
        {
            string json = httpInstance.CreateJsonRequest("getblockhash","[" + index.ToString()  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getblockhashes method returns an array of hashes of blocks
        within the timestamp range provided.The method requires
        timestampindex to be enabled.
        :param high: (numeric, required) the newer block timestamp
        :param low: (numeric, required) the older block timestamp
        :param no_orphans: (boolean) a value of true implies that
            the method will only include blocks on the main chain
        :param logical_times: (boolean)	a value of true implies that the
            method will only include logical timestamps with hashes
        :return: JSON string containing:
            "hash" (string) the block hash
            "blockhash"	(string) the block hash
            "logicalts"	(numeric) the logical timestamp
         */
        public string GetBlockHashes(WebRequestPostExample httpInstance, int high, int low, Boolean orphans,Boolean logical_times)
        {
            string options = "{\"noOrphans\":" + orphans.ToString().ToLower() + "," + "\"logicalTimes\":" + logical_times.ToString().ToLower() + "}" ;
            string json = httpInstance.CreateJsonRequest("getblockhashes","["  + high.ToString()  + ","  + low.ToString() + "," + options + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
            The getblockheader method returns information about the
        indicated block.
        :param hash: (string, required)	the block hash
        :param verbose: (boolean, optional, default=true) true returns
            a json object, false returns hex-encoded data
        :return: JSON string containing information
            about the indicated block
         */
        public string GetBlockHeader(WebRequestPostExample httpInstance, string hash, Boolean verbose)
        {
            string json = httpInstance.CreateJsonRequest("getblockheader","[" + "\"" + hash.ToString()  + "\"" + ","  + verbose.ToString().ToLower()   + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The method getchaintxstats returns statistics about the total
        number and rate of transactions in the chain.
        :param nblocks: (numeric, optional)	the number of blocks in the
            averaging window.
        :param blockhash: (string, optional) the hash of the block which
            ends the window
        :return: JSON string containing:
            "time" (numeric) the timestamp for the final block in the window
            "txcount" (numeric) the total number of transactions in the
                chain up to this point
            "window_final_block_hash" (string) the hash of the final block
                in the window
            "window_block_count" (numeric) the size of the window in the
                number of blocks
            "window_tx_count" (numeric)	the number of transactions in the
                window; this value is only returned if window_block_count is > 0.
            "window_interval" (numeric)	the elapsed time in the window in
                seconds; this value is only returned if window_block_count is > 0.
            "txrate" (numeric)	the average rate of transactions per second in
                the window; this value is only returned if window_interval is > 0

         */
        public string GetChainTxStats(WebRequestPostExample httpInstance, int num_blocks, string blockhash)
        {
            string json = httpInstance.CreateJsonRequest("getchaintxstats","["  + num_blocks.ToString()  + ","  + "\"" + blockhash +"\""  + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getdifficulty method returns the proof-of-work difficulty
        as a multiple of the minimum difficulty.
        :return: number (JSON String) the proof-of-work difficulty as
            a multiple of the minimum difficulty
         */
        public string GetDifficulty(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getdifficulty","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getlastsegidstakes method returns an object containing the
        number of blocks staked by each segid in the last X number of blocks,
        where the value of X is equal to the indicated depth.
        Only applies to -ac_staked asset chains.
        :param depth: (numeric, required) the number of blocks to scan,
            starting from the current height and working backwards.
        :return: JSON string containing:
            "NotSet" (numeric) the number of blocks that have no SegId set
            "PoW" (numeric) the number of blocks created through PoW
            "PoSPerc" (numeric) the percentage of blocks created through PoS
            "SegIds" (json) the json containing the data of number of blocks
                in each SegId
            "n" (numeric) the number of blocks staked from SegId n in the last
                X blocks, where X is equal to the indicated depth
         */
        public string GetLastSegIdStakes(WebRequestPostExample httpInstance, int depth)
        {
            string json = httpInstance.CreateJsonRequest("getlastsegidstakes","[" + depth.ToString() + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getchaintips method returns information about all known tips in
        the block tree, including the main chain and any orphaned branches.
        :return: JSON string containing:
            "height" (numeric) the height of the chain tip
            "hash" (string) the block hash of the tip
            "branchlen"	(numeric) 0 for main chain
            "status" (string) "active" for the main chain
            "height" (numeric) the height of the branch tip
            "hash" (string) the blockhash of the branch tip
            "branchlen"	(numeric) the length of the branch connecting
                the tip to the main chain
            "status" (string) the status of the chain
         */
        public string GetChainTips(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getchaintips","[" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getmempoolinfo method returns details on the active state
        of the transaction memory pool.
        :return:  JSON string containing:
            "size" (numeric) the current transaction count
            "bytes" (numeric) the sum of all transaction sizes
            "usage"	(numeric) the total memory usage for the mempool
         */
        public string GetMemPoolInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getmempoolinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
            The getrawmempool method returns all transaction ids in the
        memory pool as a json array of transaction ids.
        :param verbose: (boolean, optional, default=false) true for a json
            object, false for a json array of transaction ids
        :return: JSON string, if verbose=False: "transaction_id" (string)
            the transaction id, if verbose=True:
            "transaction_id": { .... } (json object)
            "size" (numeric) the transaction size in bytes
            "fee" (numeric) the transaction fee
            "time" (numeric) the local time transaction entered pool in
                seconds since 1 Jan 1970 GMT
            "height" (numeric) the block height wherein the transaction entered
                the mempool
            "startingpriority" (numeric) the priority when the transaction
                entered the mempool
            "currentpriority" (numeric)	the transaction priority at the current
                height
            "depends": { ... } (array) unconfirmed transactions used as
                inputs for this transaction
            "transaction_id" (string) the parent transaction id
         */
        public string GetRawMempool(WebRequestPostExample httpInstance, Boolean verbose)
        {
            string json = httpInstance.CreateJsonRequest("getrawmempool","[" + verbose.ToString().ToLower() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The getspentinfo method returns the transaction id and index where
        the given output is spent. The method requires spentindex to be enabled.
        :param txid: (string) the hex string of the transaction id.
        :param index: (number) the output's index
        :return: JSON string containing:
            "txid"	(string)	the transaction id
            "index"	(number)	the spending input index
         */

        public string GetSpentInfo(WebRequestPostExample httpInstance, string txid, int index)
        {
            string options = "{\"txid\":" + "\"" + txid.ToLower() + "\"" + "," + "\"index\":" + index.ToString() + "}";
            string json = httpInstance.CreateJsonRequest("getspentinfo","[" + options +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The gettxout method returns details about an unspent transaction output.
        :param txid: (string, required)	the transaction id
        :param vout: (numeric, required) the vout value
        :param includemempool: (boolean, optional)	whether to include the mempool
        :return: JSON string with details about an unspent transaction output
         */
        public string GetTxOut(WebRequestPostExample httpInstance, string txid, int vout, Boolean includemempool)
        {
            string json = httpInstance.CreateJsonRequest("gettxout","[" + "\"" + txid + "\"" + "," + vout.ToString() + "," + includemempool.ToString().ToLower() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The gettxoutproof method returns a hex-encoded proof showing that
        the indicated transaction was included in a block.
        :param txid: (string) a transaction hash
        :param blockhash: (string, optional) if specified, the method looks
            for the relevant transaction id in this block hash
        :return: data (JSON string)	a string that is a serialized,
            hex-encoded data for the proof
         */

        public string GetTxOutProof(WebRequestPostExample httpInstance, List<String> txid, string blockhash)
        {
            String tx_list = "[";
            foreach(var address_individual in txid)
                {
                    tx_list = tx_list + "\"" + address_individual + "\"" + ",";
                }
            if(tx_list.Length > 1)
                {
                    tx_list = tx_list.Substring(0, (tx_list.Length - 1 ) );
                }

            tx_list =tx_list + "]";
            string json;
            if(blockhash!="")
            {
                json = httpInstance.CreateJsonRequest("gettxoutproof","[" +tx_list + "," + "\"" + blockhash.ToString() + "\"" +  "]" );
            }
            else
            {
                json = httpInstance.CreateJsonRequest("gettxoutproof","[" +tx_list + ","  + ""  +  "]" );
            }
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The gettxoutsetinfo method returns statistics about the
        unspent transaction output set
        :return: JSON string containing:
            "height" (numeric) the current block height (index)
            "bestblock" (string) the best block hash hex
            "transactions" (numeric) the number of transactions
            "txouts" (numeric) the number of output transactions
            "bytes_serialized" (numeric) the serialized size
            "hash_serialized" (string) the serialized hash
            "total_amount" (numeric) the total amount
         */
        public string GetTxOutSetInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("gettxoutsetinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The kvsearch method searches for a key stored
        via the kvupdate command.
        :param key: (string, required) the key for which the user
            desires to search the chain
        :return: JSON string containing:
            "coin" (string)	the chain on which the key is stored
            "currentheight"	(numeric) the current height of the chain
            "key" (string) the key
            "keylen" (string) the length of the key
            "owner" (string) a hex string representing the owner of the key
            "height" (numeric) the height at which the key was stored
            "expiration" (numeric) the height at which the key will expire
            "flags" (numeric) 1 if the key was created with a password;
                0 otherwise
            "value" (string) the stored value
            "valuesize" (string) the amount of characters stored
         */

        public string KvSearch(WebRequestPostExample httpInstance, string key)
        {
            string json = httpInstance.CreateJsonRequest("kvsearch","[" + "\"" + key + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The kvupdate method stores a key/value pair via OP_RETURN.
        :param key: (string, required) key (should be unique)
        :param value: (string, required) value
        :param days: (numeric, required) amount of days before the
            key expires (1440 blocks/day); minimum 1 day
        :param passphrase: (string, optional) passphrase required
            to update this key
        :return: JSON string containing:
            "coin" (string)	the chain on which the key is stored
            "height" (numeric) the height at which the key was stored
            "expiration" (numeric) the height at which the key will expire
            "flags" (string the amount of days the key will be stored
            "key" (numeric) the stored key
            "keylen" (numeric) the length of the key
            "value" (numeric) the stored value
            "valuesize" (string) the length of the stored value
            "fee" (string) the transaction fee paid to store the key
            "txid" (string) the transaction id
         */

        public string KvUpdate(WebRequestPostExample httpInstance, string key, string value, int days, string passphrase)
        {
            string json = httpInstance.CreateJsonRequest("kvupdate","[" + "\"" + key + "\"" + "," + "\"" + value + "\"" + "," + "\"" + days.ToString() + "\"" + "," + "\"" + passphrase + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The minerids method returns information about the notary
        nodes and external miners at a specific block height.
        :param height: (number)	the block height for the query
        :return: JSON string containing:
            "mined":
            "notaryid" (number)	the id of the specific notary node
            "kmdaddress" (string) the address of the notary node
            "pubkey" (string) the public signing key of the notary node
            "blocks" (number)
         */

        public string MinerIds(WebRequestPostExample httpInstance, int height)
        {
            string json = httpInstance.CreateJsonRequest("minerids","[" + "\"" + height.ToString() +  "\"" +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The notaries method returns the public key, BTC address,
        and KMD address for each Komodo notary node.
        Either or both of the height and timestamp parameters will suffice.
        :param height: (number)	the block height desired for the query
        :param timestamp: (number) the timestamp of the block
            desired for the query
        :return: JSON string containing:
            "notaries": [ ... ]	(array)
            "pubkey" (string) the public signing key of the indicated
                notary node, used on the KMD network to create notary-node
                authorized transactions
            "BTCaddress" (string) the public BTC address the notary node uses
                on the BTC blockchain to create notarizations
            "KMDaddress" (string) the public KMD address the notary node uses
                on the KMD blockchain to create notarizations
            "numnotaries" (number) the number of notary nodes; typically this
                value is 64, but the value may vary on rare circumstances,
                such as during election seasons
            "height" (number) the block height number at which the notary-node
                information applies
            "timestamp" (number) the timestamp at which the notary-node
                information applies
         */
        public string Notaries(WebRequestPostExample httpInstance, int height, int timestamp)
        {
            string options;
            if(height!=0 && timestamp!=0)
                {
                options =  "\"" + height.ToString() + "\"" + "," + "\"" + timestamp.ToString()+ "\"" ;
                }
            else if(height!=0)
                {
                    options = "(" + "\"" + height.ToString() + "\"" +"}";
                }
            else
                {
                    options = "(" + "\"" + timestamp.ToString()+ "\"" + "}";
                }
            string json = httpInstance.CreateJsonRequest("notaries","[" + options +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The verifychain method verifies the coin daemon's blockchain database
        :param checklevel: (numeric, optional, 0-4, default=3)
            indicates the thoroughness of block verification
        :param numblocks: (numeric, optional, default=288, 0=all)
            indicates the number of blocks to verify
        :return: true/false	(JSON string) whether the
            verification was successful
         */
        public string VerifyChain(WebRequestPostExample httpInstance, int check_level, int num_blocks)
        {
            string json = httpInstance.CreateJsonRequest("verifychain","[" + check_level.ToString() + "," + num_blocks.ToString() +  "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The verifytxoutproof method verifies that a proof points
        to a transaction in a block.
        :param proofstring: (string, required)	the hex-encoded proof
            generated by gettxoutproof
        :return: "txid"	(JSON string) the transaction ids to which the
            proof commits; the array is empty if the proof is invalid
         */
        public string VerifyTxOutProof(WebRequestPostExample httpInstance, string proofstring)
        {
            string json = httpInstance.CreateJsonRequest("verifytxoutproof","[" + "\"" + proofstring + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }
    }
}