using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
         //APPROPRIATE LOGIN INFORMATION NEEDS TO BE ENTERED HERE BY THE USER.
        string username = "user2027525480";
        string password =  "pass8bd57d606607e3978406658840c66a1db7b44d24c75991c122589863eaf3893569";
        public static void Test()
        {
             
            WebRequestPostExample httpInstance = new WebRequestPostExample();
            string result = httpInstance.GetWalletInfo(httpInstance);
            Console.WriteLine(result);

            result = httpInstance.BackupWallet(httpInstance,"backup");
            Console.WriteLine(result);

            result = httpInstance.DumpWallet(httpInstance, "backup");
            Console.WriteLine(result);

            result = httpInstance.GetAccount(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw");
            Console.WriteLine(result);

            Console.WriteLine("Testing Dump Private Key: ");
            result = httpInstance.DumpPrivateKey(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw" );
            Console.WriteLine(result);

            Console.WriteLine("Testing Get Raw Change Address");
            result = httpInstance.GetRawChangeAddress(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing Get Received by Address");
            result = httpInstance.GetReceivedByAddress(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw", "1");
            Console.WriteLine(result);

            Console.WriteLine("Testing Get Transaction");
            result = httpInstance.GetTransaction(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610" , "False");
            Console.WriteLine(result);

            Console.WriteLine("Testing Get Unconfirmed Balance");
            result = httpInstance.GetUnconfirmedBalance(httpInstance);
            Console.WriteLine(result);
            
            Console.WriteLine("Testing Import Address");
            result = httpInstance.ImportAddress(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw" , "testing", "True");
            Console.WriteLine(result);
            //Getting Error. The Wallet already contains private key for this address or script.

            Console.WriteLine("Testing GetAddressBalance");
            string[] input = {"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw"};
            result = httpInstance.GetAddressBalance(httpInstance, new List<string>(input));
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddressDeltas");
            result = httpInstance.GetAddressDeltas(httpInstance, new List<string>(input), 0, 0, false);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddressMemPool");
            result = httpInstance.GetAddressMemPool(httpInstance, new List<string>(input));
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddressTxIds");
            result = httpInstance.GetAddressTxIds(httpInstance, new List<string>(input), 0, 0);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddressUTxos");
            result = httpInstance.GetAddressUTuxos(httpInstance, new List<string>(input), false);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetSnapshot");
            result = httpInstance.GetSnapshot(httpInstance, 0);
            Console.WriteLine(result);

            Console.WriteLine("Testing CoinSupply");
            result = httpInstance.CoinSupply(httpInstance,0);       //ERROR: Could not Calculate Supply
            Console.WriteLine(result);
            
            Console.WriteLine("Testing GetBestBlockHash");
            result = httpInstance.GetBestBlockHash(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlock");
            result = httpInstance.GetBlock(httpInstance, "027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71",false);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockChainInfo");
            result = httpInstance.GetBlockChainInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockCount");
            result = httpInstance.GetBlockCount(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockHash");
            result = httpInstance.GetBlockHash(httpInstance, 0);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockHashes");
            result = httpInstance.GetBlockHashes(httpInstance, 0,1,true,true);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockHeader");
            result = httpInstance.GetBlockHeader(httpInstance,"027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71", true );
            Console.WriteLine(result);

            Console.WriteLine("Testing GetChainTips");
            result = httpInstance.GetChainTips(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetChainTxStats");
            result = httpInstance.GetChainTxStats(httpInstance,0,"027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71");
            Console.WriteLine(result);

            Console.WriteLine("Testing GetDifficulty");
            result = httpInstance.GetDifficulty(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetlastSegIDStakes");
            result = httpInstance.GetLastSegIdStakes(httpInstance,1);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetMemPoolInfo");
            result = httpInstance.GetMemPoolInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetRawMemPool");
            result = httpInstance.GetRawMempool(httpInstance,true);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetSpentInfo");
            result = httpInstance.GetSpentInfo(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610", 0);  //ERROR: UNABLE TO GET SPENT INFO
            Console.WriteLine(result);

            Console.WriteLine("Testing GetTxOut");
            result = httpInstance.GetTxOut(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610", 0, false);
            Console.WriteLine(result);


            string[] test_input = {"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610"};
            Console.WriteLine("Testing GetTxOutProof");
            result = httpInstance.GetTxOutProof(httpInstance,new List<String>(test_input), "027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71");
            Console.WriteLine(result);

            Console.WriteLine("Testing GetTxOutSetInfo");
            result = httpInstance.GetTxOutSetInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing KvSearch");
            result = httpInstance.KvSearch(httpInstance, "key");
            Console.WriteLine(result);

            Console.WriteLine("Testing KvUpdate");
            result = httpInstance.KvUpdate(httpInstance, "key","value", 0, "password"); //ERROR:INSUFFICIENT FUNDS.
            Console.WriteLine(result);

            Console.WriteLine("Testing MinerIds");
            result = httpInstance.MinerIds(httpInstance, 0); //ERROR: COULD NOT EXTRACT MINER IDS.
            Console.WriteLine(result);

            Console.WriteLine("Testing Notaries");
            result = httpInstance.Notaries(httpInstance,1,1); 
            Console.WriteLine(result);

            Console.WriteLine("Testing VerifyChain");
            result = httpInstance.VerifyChain(httpInstance,0,0); 
            Console.WriteLine(result);

            Console.WriteLine("Testing VerifyTxOutProof");
            result = httpInstance.VerifyTxOutProof(httpInstance,"null");    //ERROR: NEED HEX STRING TO CHECK.
            Console.WriteLine(result);

            Console.WriteLine("Testing GetInfo");
            result = httpInstance.GetInfo(httpInstance);    //ERROR: NEED HEX STRING TO CHECK.
            Console.WriteLine(result);

            Console.WriteLine("Testing Help");
            result = httpInstance.Help(httpInstance,"getaddressbalance");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_GetPaymentDisclosure");
            result = httpInstance.Z_GetPaymentDisclosure(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610","0", "0", "refund");   //No information available about transaction.
            Console.WriteLine(result);

            Console.WriteLine("Testing Generate");
            result = httpInstance.Generate(httpInstance,0);  
            Console.WriteLine(result);


            Console.WriteLine("Testing GetGenerate");
            result = httpInstance.GetGenerate(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing SetGenerate");
            result = httpInstance.SetGenerate(httpInstance, false, 2);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBlockSubsidy");
            result = httpInstance.GetBlockSubsidy(httpInstance,1);
            Console.WriteLine(result);

            string[] capabilities = {};
            Console.WriteLine("Testing GetBlockTemplate");
            result = httpInstance.GetBlockTemplate(httpInstance,"disablecb",new List<String>(capabilities), ""); 
            Console.WriteLine(result);

            Console.WriteLine("Testing GetLocalSolps");
            result = httpInstance.GetLocalSolps(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetMiningInfo");
            result = httpInstance.GetMiningInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetNetworkSlops");
            result = httpInstance.GetNetworkSolps(httpInstance,120,-1);
            Console.WriteLine(result);

            Console.WriteLine("Testing PrioritiSetTransaction");
            result = httpInstance.PrioritiseTransaction(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610",0.0,0);
            Console.WriteLine(result);

            Console.WriteLine("Testing SubmitBlock");
            result = httpInstance.SubmitBlock(httpInstance,"",""); //NEED HEX BLOCK ADDRESS TO CHECK.
            Console.WriteLine(result);

            Console.WriteLine("Testing ClearBanned");
            result = httpInstance.ClearBanned(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing DisconnectNode");
            result = httpInstance.DisconnectNode(httpInstance,"127.0.0.1:10608");
            Console.WriteLine(result);

            Console.WriteLine("Testing DumpPrivKey");
            result = httpInstance.DumpPrivKey(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw");
            Console.WriteLine(result);

            Console.WriteLine("Testing EncryptWallet");
            result = httpInstance.EncryptWallet(httpInstance,"abc123");
            Console.WriteLine(result);

            Console.WriteLine("Testing GetBalance");
            result = httpInstance.GetBalance(httpInstance,"",1,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetNewAddress");
            result = httpInstance.GetNewAddress(httpInstance,"");
            Console.WriteLine(result);

            Console.WriteLine("Testing ImportPrivKey");
            result = httpInstance.ImportPrivKey(httpInstance,"UtZS3VWNtACyVNsJa2GJaJ89xS7hvotn47WpiSYDE9SDD59xunzW","",true);
            Console.WriteLine(result);

            Console.WriteLine("Testing ImportWallet");
            result = httpInstance.ImportWallet(httpInstance,"");   
            Console.WriteLine(result);

            Console.WriteLine("Testing KeyPoolRefill");
            result = httpInstance.KeyPoolRefill(httpInstance,100);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListAddressGroupings");
            result = httpInstance.ListAddressGroupings(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListLockUnspent");
            result = httpInstance.ListLockUnspent(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListReceivedByAddress");
            result = httpInstance.ListReceivedByAddress(httpInstance,1,true,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListsinCeBlock");
            result = httpInstance.ListsInCeBlock(httpInstance,"027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71",1,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListTransactions");
            result = httpInstance.ListTransactions(httpInstance,"",10,0,false); 
            Console.WriteLine(result);


            string[] address_input = {""};
            Console.WriteLine("Testing ListUnspent");
            result = httpInstance.ListUnspent(httpInstance,1,9999999,new List<String>(address_input));
            Console.WriteLine(result);

            Console.WriteLine("Testing LockUnspent");
            result = httpInstance.LockUnspent(httpInstance,false,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610",0); 
            Console.WriteLine(result);

            Console.WriteLine("Testing ResendWalletTransactions");
            result = httpInstance.ResendWalletTransactions(httpInstance);
            Console.WriteLine(result);

            Dictionary<String,Double> dictionary_to_send = new Dictionary<String,Double>();
            string[] test_send_many_list = {""};
            dictionary_to_send.Add("REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw",0.02);
            Console.WriteLine("Testing SendMany");
            result = httpInstance.SendMany(httpInstance,dictionary_to_send,1,"",new List<String>(test_send_many_list));
            Console.WriteLine(result);

            Console.WriteLine("Testing SendToAddress");
            result = httpInstance.SendToAddress(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw",0.02,"hello","hi",true);
            Console.WriteLine(result);

            Console.WriteLine("Testing SetPubKey");
            result = httpInstance.SetPubKey(httpInstance,"0260801166cebdc9be1e3460ba9e4959fb29feee7725f565ffc296fa4636aa706f");
            Console.WriteLine(result);

            Console.WriteLine("Testing SetTxFee");
            result = httpInstance.SetTxFee(httpInstance,0.05);
            Console.WriteLine(result);
            
            Console.WriteLine("Testing SignMessage");
            result = httpInstance.SignMessage(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw", "signed");
            Console.WriteLine(result);

            Console.WriteLine("Testing WalletLock");
            result = httpInstance.WalletLock(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing WalletTestPhrase");
            result = httpInstance.WalletPassphrase(httpInstance,"abc123",0);
            Console.WriteLine(result);

            Console.WriteLine("Testing WalletPassphraseChange");
            result = httpInstance.WalletPassphraseChange(httpInstance,"abc123","abc124");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ExportKey");
            result = httpInstance.Z_ExportKey(httpInstance, "zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5"); 
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ExportViewingKey");
            result = httpInstance.Z_ExportViewingKey(httpInstance, "zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5"); 
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_export_wallet");
            result = httpInstance.Z_ExportWallet(httpInstance, "zwalletexport");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_GetBalance");
            result = httpInstance.Z_GetBalance(httpInstance, "REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw", 1);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_GetNewAddress");
            result = httpInstance.Z_GetNewAddress(httpInstance);
            Console.WriteLine(result);

            String contents = "["  + "opid-6a9da0dd-a950-4d95-848c-d3c18e44be03"  + "]";
            String[] contents_list = {contents};
            List<String> new_list = new List<String>(contents_list);
            Console.WriteLine("Testing GetOperationResult");
            result = httpInstance.Z_GetOperationResult(httpInstance,new_list);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetOperationStatus");
            result = httpInstance.Z_GetOperationStatus(httpInstance,new_list);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_GetTotalBalance");
            result = httpInstance.Z_GetTotalBalance(httpInstance,1,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ImportKey");
            result = httpInstance.Z_ImportKey(httpInstance,"Hwhf3O7QqwbPXhZcY+b8xWLBy0Im3CDDm+oVTZVaIi8oczkloc9VvEOh3rKXyb+34fju2KgUrhzdjxLWXMLlSAo=","whenkeyisnew",0);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ImportViewingKey");
            result = httpInstance.Z_ImportViewingKey(httpInstance,"Hwhf3O7QqwbPXhZcY+b8xWLBy0Im3CDDm+oVTZVaIi8oczkloc9VvEOh3rKXyb+34fju2KgUrhzdjxLWXMLlSAo=","whenkeyisnew",0);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ImportWallet");
            result = httpInstance.Z_ImportWallet(httpInstance,"/Users/adityarajguru/komodo/src/./zwalletexport");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ListAddresses");
            result = httpInstance.Z_ListAddresses(httpInstance,false);
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ListOperationIDs");
            result = httpInstance.Z_ListOperationIds(httpInstance,"success");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ListReceivedByAddress");
            result = httpInstance.Z_ListReceivedByAddress(httpInstance, "zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5", 1);
            Console.WriteLine(result);

            string[] address_input_z = {"zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5"};
            Console.WriteLine("Testing Z_ListUnspent");
            result = httpInstance.Z_ListUnspent(httpInstance,1,9999999,false,new List<String>(address_input_z));
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_MergeToAddress");
            result = httpInstance.Z_MergeToAddress(httpInstance,new List<String>(address_input_z),"zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5",0.0002,0,0,"");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_SendMany");
            result = httpInstance.Z_SendMany(httpInstance, "zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5",dictionary_to_send,"",1,0.02); //ERROR
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ShieldCoinBase");
            result = httpInstance.Z_ShieldCoinBase(httpInstance,"zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5","zs1jmqt4tc4mn7vy2ql6qmwnf4k3u0jjkkdg4s5nawju8jcpfags4ryf2j0ds8jrmdknpsujq40hm5",0.01,5);
            Console.WriteLine(result);

            Console.WriteLine("Testing ZCBenchmark");
            result = httpInstance.ZCBenchmark(httpInstance,"time",1);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetAddedNodeInfo");
            result = httpInstance.GetAddedNodeInfo(httpInstance,false,"");
            Console.WriteLine(result);

            Console.WriteLine("Testing GetConnectionCount");
            result = httpInstance.GetConnectionCount(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetDeprecationInfo");
            result = httpInstance.GetDeprecationInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetNetTotals");
            result = httpInstance.GetNetTotals(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetNetworkInfo");
            result = httpInstance.GetNetworkInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing GetPeerInfo");
            result = httpInstance.GetPeerInfo(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing ListBanned");
            result = httpInstance.ListBanned(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing Ping");
            result = httpInstance.Ping(httpInstance);
            Console.WriteLine(result);

            Console.WriteLine("Testing SetBan");
            result = httpInstance.SetBan(httpInstance,"127.0.0.1:10607","add",0,false);
            Console.WriteLine(result);

            Dictionary<String,Double> test1 = new Dictionary<String,Double>();
            test1.Add("ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610",0);
            Dictionary<String,Double> test2 = new Dictionary<String,Double>();
            test2.Add("REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw",0.02);
            Console.WriteLine("Testing CreateRawTransaction");
            result = httpInstance.CreateRawTransaction(httpInstance,test1,test2);
            Console.WriteLine(result);

            Console.WriteLine("Testing Decode Raw Transaction");
            result = httpInstance.DecodeRawTransaction(httpInstance,"010000000110c62f665b7a9df6d793f1b7e1496049b1bdfde205917e2f0c31550d0c4c2cff0000000000ffffffff0180841e00000000001976a9143ae0a346d42bc47a5217d8158169431efd12827c88ac00000000");
            Console.WriteLine(result);

            Console.WriteLine("Testing Decode Script");
            result = httpInstance.DecodeScript(httpInstance,"010000000110c62f665b7a9df6d793f1b7e1496049b1bdfde205917e2f0c31550d0c4c2cff0000000000ffffffff0180841e00000000001976a9143ae0a346d42bc47a5217d8158169431efd12827c88ac00000000");
            Console.WriteLine(result);

            Console.WriteLine("Testing Fund Raw Transaction");
            result = httpInstance.FundRawTransaction(httpInstance,"010000000110c62f665b7a9df6d793f1b7e1496049b1bdfde205917e2f0c31550d0c4c2cff0000000000ffffffff0180841e00000000001976a9143ae0a346d42bc47a5217d8158169431efd12827c88ac00000000");
            Console.WriteLine(result);

            Console.WriteLine("Testing GetRawTransaction");
            result = httpInstance.GetRawTransaction(httpInstance,"ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610",0);
            Console.WriteLine(result);

            Console.WriteLine("Testing Send Raw Transaction");
            result = httpInstance.SendRawTransaction(httpInstance,"010000000110c62f665b7a9df6d793f1b7e1496049b1bdfde205917e2f0c31550d0c4c2cff0000000000ffffffff0180841e00000000001976a9143ae0a346d42bc47a5217d8158169431efd12827c88ac00000000",false);  
            Console.WriteLine(result);

            Console.WriteLine("Testing Sign Raw Transaction");
            result = httpInstance.SignRawTransaction(httpInstance,"010000000110c62f665b7a9df6d793f1b7e1496049b1bdfde205917e2f0c31550d0c4c2cff0000000000ffffffff0180841e00000000001976a9143ae0a346d42bc47a5217d8158169431efd12827c88ac00000000");
            Console.WriteLine(result);

            string[] keys = {"UtZS3VWNtACyVNsJa2GJaJ89xS7hvotn47WpiSYDE9SDD59xunzW"};
            Console.WriteLine("Testing CreateMultiSig");
            result = httpInstance.CreateMultiSig(httpInstance,1,new List<String>(keys)); 
            Console.WriteLine(result);

            Console.WriteLine("Testing DecodeCCOpret");
            result = httpInstance.DecodeCCopret(httpInstance,"010000000110c62f665b7a9df6d793f1b7e1496049b1bdfde205917e2f0c31550d0c4c2cff0000000000ffffffff0180841e00000000001976a9143ae0a346d42bc47a5217d8158169431efd12827c88ac00000000");
            Console.WriteLine(result);

            Console.WriteLine("Testing EstimateFee");
            result = httpInstance.EstimateFee(httpInstance,0);
            Console.WriteLine(result);

            Console.WriteLine("Testing EstimatePriority");
            result = httpInstance.EstimatePriority(httpInstance,0);
            Console.WriteLine(result);

            Console.WriteLine("Testing InvalidateBlock");
            result = httpInstance.InvalidateBlock(httpInstance,"027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71");
            Console.WriteLine(result);

            Console.WriteLine("Testing ReconsiderBlock");
            result = httpInstance.ReconsiderBlock(httpInstance,"027e3758c3a65b12aa1046462b486d0a63bfa1beae327897f56c5cfb7daaae71");
            Console.WriteLine(result);

            Console.WriteLine("Testing TxNotarizedConfirmed");
            result = httpInstance.TxNotarizeConfirmed(httpInstance, "ff2c4c0c0d55310c2f7e9105e2fdbdb1496049e1b7f193d7f69d7a5b662fc610");
            Console.WriteLine(result);

            Console.WriteLine("Testing ValidateAddress");
            result = httpInstance.ValidateAddress(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw");
            Console.WriteLine(result);

            Console.WriteLine("Testing VerifyMessage");
            result = httpInstance.VerifyMessage(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw","","");
            Console.WriteLine(result);

            Console.WriteLine("Testing Z_ValidateAddress");
            result = httpInstance.Z_ValidateAddress(httpInstance,"REeWNkTotZfZHoZWCJ3MSSFLstguxL2Ckw");
            Console.WriteLine(result);

            Console.WriteLine("Testing Complete");

        }
    }
}