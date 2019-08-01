using System;
using System.Collections.Generic;

namespace Blockchain
{


public partial class WebRequestPostExample
{
    /*
    The migrate_createburntransaction method creates a transaction burning a specific amount of coins or tokens. This method also creates a payouts object which is later used to create an import transaction for the value corresponding to the burned amount. This method should be called on the source chain.

    The method creates a burn transaction and returns it. This should be broadcast to the source chain using the sendrawtransaction method. After the burn transaction is successfully mined, the user might have to wait for some amount of time for the back notarization to reach the source chain. The back notarization contains the MoMoM fingerprints of the mined block that contains the burn transaction.

    The hex value of the burn transaction along with the other returned value payouts are used as arguments for the migrate_createimporttransaction method.

Arguments:

    DestChain: The name of the destination chain
    DestAddress: The address on the destination chain where couns are to be sent;the pubkey if tokens are to be sent
    amount: the amount in coins or tokens that should be burned on the source chain and created on the destination chain; if the indicated assets are tokens, the amount can be set only to 1, as only migration of non-fungible tokens are supported at this time
    tokenid: token id in hex; if set, the software assumes that the user is migrating tokens
    
Returns:
    
    "payouts"	(string)	a hex string of the created payouts; this value is passed into the migrate_createimporttransaction method
    "BurnTxHex"	(string)	a hex string of the returned burn transaction
    */
    
    public string MigrateCreateBurnTransaction(WebRequestPostExample httpInstance,string DestinationName,string DestinationChainAddress, double Amount, string TokenID)
    {
        string json =httpInstance.CreateJsonRequest("migrate_createburntransaction","[\"" + DestinationName + "\"," +  "\"" + DestinationChainAddress + "\"," + Amount.ToString() + "]");
        string result = CallHttpRequest(json);
        return result;
    }

    /*
    
    The migrate_converttoexport method allows the user to create a customized burn transaction (as opposed to a fully automated burn transaction). This method converts a given transaction to a burn transaction.

    The method adds proof data to the transaction, extracts the transaction vouts, calculates their value, and burns the value by sending it to an opreturn vout. This vout is then added to the created transaction. (An opreturn vout cannot be spent at a later date, and therefore funds sent to an opreturn vout are permanently burnt.)

    The other returned value, payouts, is used in the migrate_createimporttransaction method.

    The caller of the method bears the responsibility to fund and sign the returned burn transaction using the methods fundrawtransaction and signrawtransaction.

    The signed burn transaction must be broadcast to the sendrawtansaction method.
    
    Arguments:
    
    "burntx"	(string, required)	the burn transaction in hex format
    "destChain"	(string, required)	the name of the destination chain
    
    Returns:
    
    "payouts"	(string)	a hex string of the created payouts; this is passed into the migrate_createimporttransaction method
    "exportTx"	(string)	a hex string of the returned burn transaction
    
    */
    
    public string MigrateConvertToExport(WebRequestPostExample httpInstance, string burnTx, string destChain)
    {
        string json = httpInstance.CreateJsonRequest("migrate_converttoexport","[" + "\"" + burnTx + "\"," + "\"" + destChain + "\"" + "]");
        string result = CallHttpRequest(json);
        return result;
    }

    /*
    
    The migrate_createimporttransaction method performs the initial step in creating an import transaction. This method should be called on the source chain.
    This method returns a created import transaction in hex format. This string should be passed to the migrate_completeimporttransaction method on the main KMD chain to be extended with the MoMoM proof object.
    When using the MoMoM backup solution (described later), the created import transaction is not passed to the migrate_completeimporttransaction method.
    The user may need to wait for some time before the back notarizations objects are stored in the destination chain.
    
    Arguments:
    
    "burntx"	(string, required)	the burn transaction in hex format returned from the previous method
    "payouts"	(string, required)	the payouts object in hex format returned from the previous method and used for creating an import transaction
    "notaryTxid1"	(string, optional)	the notary approval transaction id 1, to be passed if the MoMoM backup solution is used for notarization
    "notaryTxidN"	(string, optional)	the notary approval transaction id N, to be passed if the MoMoM backup solution is used for notarization

    Returns:
    
    "ImportTxHex"	(string)	the created import transaction in hex format
    
    */
    
    public string MigrateCreateImportTransaction(WebRequestPostExample httpInstance, string burnTx, string payouts, string notarytxid_n)
    {
        string json = httpInstance.CreateJsonRequest("migrate_createimporttransaction","[" + "\"" + burnTx + "\"," + "\"" + payouts + "\"" + ((notarytxid_n!="")? "\"" + notarytxid_n + "\"" : "\"" + "\"") + "]");
        string result = CallHttpRequest(json);
        return result;
    }

    /*
    
    The migrate_completeimporttransaction method performs the finalizing step in creating an import transaction. This method should be called on the KMD (Komodo) chain.

    This method returns the import transaction in hex format, updated with the MoMoM proof object. This object provides confirmation that the burn transaction exists in the source chain.

    The finalized import transaction should be broadcast on the destination chain through the sendrawtransaction method.

    Komodo recommends that the user wait until the notarization objects are stored in the destination chain before broadcasting the import transaction. Otherwise an error message is returned.

    In the event that an error is returned, simply wait until the notarization objects are stored in the KMD chain and try again.
    
    Arguments:
    
    "importtx"	(string, required)	the import transaction in hex format created using the previous method
    "offset"	(string, optional)	the number of blocks below the current KMD(Komodo) blockchain height in which a MoMoM proof must be searched

    Returns:
    
    "ImportTxHex"	(string)	import transaction in hex extended with the MoMoM proof of burn transaction
    
    */
    
    public string MigrateCompleteImportTransaction(WebRequestPostExample httpInstance, string importTx, string offset)
    {
        string json = httpInstance.CreateJsonRequest("migrate_completeimporttransaction","[" + "\"" + importTx + "\","  + ((offset!="")? "\"" + offset + "\"" : "\"" + "\"" ) + "]");
        string result = CallHttpRequest(json);
        return result;
    }

    /*
    
    The migrate_checkburntransactionsource method allows a notary operator to check the burn transaction's structure and verify its presence in the source chain.
    
    Arguments:
    
    "burntxid"	(string, required)	the burn transaction's id
    
    Returns:
    
    "sourceSymbol"	(string)	the source chain's name
    "targetSymbol"	(string)	the target chain's name
    "targetCCid"	(number)	the target chain's CCid
    "tokenid"	(string, optional)	the token id if a token is to be migrated
    "TxOutProof"	(string)	the proof of the burn transaction's existence in the source chain
    
    */
    
    public string MigrateCheckBurnTransactionSource(WebRequestPostExample httpInstance, string burnTxId)
    {
        string json = httpInstance.CreateJsonRequest("migrate_checkburntransactionsource","[" + "\"" + burnTxId + "\""  + "]");
        string result = CallHttpRequest(json);
        return result;
    }
    
    /*
    
    A notary operator uses the migrate_createnotaryapprovaltransaction method to create an approval transaction in the destination chain with the proof of the burn transaction's existence in the source chain.

    The returned notary approval transaction should be broadcast to the destination chain using the sendrawtransaction method.
    
    Arguments:
    
    "burntxid"	(string, required)	the burn transaction's id
    "txoutproof"	(string, required)	the proof of the burn transaction's existence
    
    Returns:
    
    "NotaryTxHex"	(string)	notary approval transaction in hex format
    
    */

    public string MigrateCreateNotaryApprovalTransaction(WebRequestPostExample httpInstance, string burnTxId, string txOutProof)
    {
        string json = httpInstance.CreateJsonRequest("migrate_createnotaryapprovaltransaction","[" + "\"" + burnTxId + "\"," + "\"" + txOutProof + "\""  + "]");
        string result = CallHttpRequest(json);
        return result;
    }

    /*
    
    For creating more coins in the chain with -ac_import=PUBKEY enabled, use the selfimport method
    The method returns a source transaction that contains a parameter with the amount of coins to create
    The returned value is a proof of the trusted pubkey owner's intention to create new coins in the chain
    The returned source transaction should be broadcast to the chain using the sendrawtransaction method. The source transaction spends a txfee=10000 satoshis from the -ac_pubkey owner's uxtos
    After the source transaction is mined, the import transaction should also be broadcasted to the chain with the sendrawtransaction method. After this transaction is mined, its vout contains the amount of created coins in the chosen destination address
    
    Arguments:
    
    "destAddress"	(string, required)	the address where the created coins should be sent
    "amount"	(number, required)	the amount in coins to create
    
    Returns:
    
    "SourceTxHex"	(string)	the source transaction in hex format
    "ImportTxHex"	(string)	the import transaction in hex format

    
    */
    public string SelfImport(WebRequestPostExample httpInstance, string DestAddress, double amount)
    {
        string json =httpInstance.CreateJsonRequest("selfimport","[\"" +  DestAddress + "\","  + amount.ToString() + "]");
        string result = CallHttpRequest(json);
        return result;
    }

    /*
    
    The calc_MoM method calculates the value of the merkle root of the blocks' merkle roots (MoM), starting from the block of the indicated height for the chosen depth.
    
    Arguments:
    
    "height"	(number, required)	the block height from which the MoM calculation must begin
    "MoMdepth"	(number, required)	the number of blocks to include in the MoM calculation
    
    Returns:
    
    "coin"	(string)	the chain's name
    "height"	(string)	the starting block height
    "MoMdepth"	(number)	the number of blocks included in the MoM calculation
    "MoM"	(string)	the MoM value
    
    */
    
    public string CalcMOM(WebRequestPostExample httpInstance, int height, double MoMdepth)
    {
        string json =httpInstance.CreateJsonRequest("calc_MoM","[\"" +  height.ToString() + "\","  + "\"" +  MoMdepth.ToString() + "\"" + "]");
        string result = CallHttpRequest(json);
        return result;
    }
    
    /*
    
    The MoMoMdata method calculates the value of the merkle root of merkle roots of the blocks' merkle roots (MoMoM), starting from the block of the indicated height for the data of the indicated chain.
    
    Arguments:
    
    "symbol"	(string, required)	the chain's name whose data's MoMoM value is to be calculated
    "kmdheight"	(number, required)	the number of blocks to include in the MoM calculation
    "ccid"	(number, required)	the chain's CCid
    
    Returns:
    
    "coin"	(string)	the chain's name
    "kmdheight"	(string)	the starting block's height
    "ccid"	(number)	the chain's CCid
    "MoMs"	(string)	the array of MoM values
    "notarizationHash"	(string)	the first found notarization transaction id for the chain
    "MoMoM"	(string)	the MoMoM value
    
    */

    public string MoMoMData(WebRequestPostExample httpInstance, string symbol, int KMDHeight, int CCId)
    {
        string json =httpInstance.CreateJsonRequest("MoMoMdata","[\"" +  symbol + "\","  + "\"" +  KMDHeight.ToString() + "\"," + "\"" + CCId.ToString() + "\"" +  "]");
        string result = CallHttpRequest(json);
        return result;

    }
    
    /*
    
    The assetchainproof method scans the chain for the back MoM notarization for a transaction corresponding to the given transaction id and returns a proof object with MoM branch. Scanning is performed from the height up to the chain tip, with a limit of 1440 blocks.
    
    Arguments:
    
    "txid"	(string, required)	the transaction id for which a proof object must be returned
    
    Returns:
    
    "proof object"	(string)	the returned proof object with MoM branch in hex format
    
    */

    public string AssetChainProof(WebRequestPostExample httpInstance, string TxId)
    {
        string json =httpInstance.CreateJsonRequest("assetchainproof","[\"" + TxId +  "\"" + "]");
        string result = CallHttpRequest(json);
        return result;
    }
    
    /*
    
    The getNotarisationsForBlock method returns the notarization transactions within the block of the given block hash.
    
    Arguments:
    
    "height"	(number, required)	the block number of the block to be searched
    
    Returns:
    
    "Notary Cluster"	(string)	refers to the notary group which performed the notarizations; KMD for the main Komodo notaries, LABS for the LABS notaries
    "txid"	(string)	the notarization transaction's id
    "chain"	(string)	the chain that has been notarized
    "height"	(number)	the notarization transaction's block height
    "blockhash"	(string)	the hash of the notarization transaction's block
    "notaries"	(array)	the ids of the notaries who performed the notarization
    
    */

    public string GetNotarizationsForBlock(WebRequestPostExample httpInstance, int height)
    {
        string json =httpInstance.CreateJsonRequest("getNotarisationsForBlock","[" + height.ToString() + "]");
        string result = CallHttpRequest(json);
        return result;
    }

    /*
    
    The scanNotarisationsDB method scans the notarization database backwards from the given block height for a notarization of the chain with the given name (symbol).
    
    Arguments:
    
    "blockHeight"	(number, required)	the starting block height from which notarizations are to be searched
    "symbol"	(string, required)	the chain's name whose notarizations are to be searched
    "blocksLimit"	(number, optional)	an optional block depth to search for notarizations
    
    Returns:
    
    "height"	(number)	the block height of the notarization transaction id that has been found
    "hash"	(string)	the hash of the notarization transaction id that has been found
    "opreturn"	(string)	the notarization data in hex format
    
    */
    
    public string ScanNotarisationsDB(WebRequestPostExample httpInstance, int BlockHeight, string symbol, string BlocksLimit)
    {
        string json =httpInstance.CreateJsonRequest("scanNotarisationsDB","[" + "\"" + BlockHeight.ToString() + "\"" +  "," + "\"" + symbol + "\"," + ((BlocksLimit!="")?"\"" + BlocksLimit + "\"" : "\"" + "\"") + "]");
        string result = CallHttpRequest(json);
        return result;   
    }
    
    /*
    
    The getimports method lists import transactions in the indicated block of the chain.
    
    Arguments:
   
    "hash or height"	(string or number, required)	the block's hash or height to be searched
    
    Returns:
    
    "imports"	(array)	
    "txid"	(string)	the import transaction id
    "amount"	(number)	the import transaction's value in coins
    "export"	(json)	the export or burn transaction's infomation
    "txid"	(string)	the export transaction's id
    "amount"	(number)	the export transaction's value
    "txid"	(string)	the export transaction's id
    "source"	(string)	the source chain's name
    "tokenid"	(string,optional)	the source chain's token id, if tokens are imported
    "TotalImported"	(number)	the total imported amount in coins
    
    */

    public string GetImports(WebRequestPostExample httpInstance, string BlockHash, int height)
    {
        string json =httpInstance.CreateJsonRequest("getimports","[" + ((BlockHash!="")?"\"" + BlockHash + "\"" : height.ToString()) + "]");
        string result = CallHttpRequest(json);
        return result; 
    }
    
    /*

    The getwalletburntransactions method lists all the burn transactions in the current wallet.
    
    Arguments:
    
    "count"	(number, optional)	the number of burn transactions to be returned; if omitted, defaults to 10 burn transactions
    
    Returns:
    
    "txid"	(string)	the burn transaction's id
    "burnedAmount"	(number)	the burned value in coins
    "tokenid"	(string, optional)	the token id, if tokens are burned
    "targetSymbol"	(string)	the target chain's name
    "targetCCid"	(number)	the target chain's CCid
    
    */

    public string GetWalletBurnTransactions(WebRequestPostExample httpInstance, int count)
    {
        string json =httpInstance.CreateJsonRequest("getwalletburntransactions","[" + "\"" + count.ToString() + "\"" + "]");
        string result = CallHttpRequest(json);
        return result; 
    }
}

}
