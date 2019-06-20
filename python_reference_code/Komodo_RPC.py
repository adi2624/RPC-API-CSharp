import requests

######################################
#   Project: Komodo RPC API (Python) #
#   Author: Vaibhav Murkute          #
######################################

class KomodoRPC:
    def __init__(self, node_addr='127.0.0.1', rpc_port='7777', req_method='POST', rpc_username='', rpc_password=''):
        self.node_addr = node_addr
        self.p2p_port = rpc_port
        self.req_method = req_method
        self.rpc_username = rpc_username
        self.rpc_password = rpc_password
        self.req_auth = {
            'user': rpc_username,
            'pass': rpc_password
        }
        self.req_url = 'http://'+self.node_addr+':'+self.p2p_port+'/';
        self.req_headers = {
            'content-type': 'text/plain;'
        }

    def RPC(self, data_string):
        response = requests.post(self.req_url, headers=self.req_headers, data=data_string, auth=(self.rpc_username, self.rpc_password))
        if(response.ok):
            return response.text
        else:
            return 'Failed with Status Code: '+str(response.status_code)+', reason: '+str(response.reason)

#################################################### Wallet Commands ##################################################################
    def getwalletinfo(self):
        # id field need to be updated
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getwalletinfo", "params": [] }'
        return self.RPC(data)

    def backupwallet(self, filename):
        '''
            This method requires that the coin daemon have the 'exportdir' runtime parameter enabled.
            exportdir tells the coin daemon where to store the wallet backup files created through the backupwallet and dumpwallet calls.
            Parameters: the 'destination' filename, saved in the directory set by the exportdir runtime parameter
        '''
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "backupwallet", "params": ["'+str(filename)+'"] }'
        return self.RPC(data)

    def dumpprivkey(self, address):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "dumpprivkey", "params": ["'+str(address)+'"] }'
        return self.RPC(data)

    def dumpwallet(self, filename):
        '''
        This method requires that the coin daemon have the 'exportdir' runtime parameter enabled.
        exportdir tells the coin daemon where to store the wallet backup files created through the backupwallet and dumpwallet calls.
        Parameters: the 'destination' filename, saved in the directory set by the exportdir runtime parameter
        '''
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "dumpwallet", "params": ["' + str(filename) + '"] }'
        return self.RPC(data)

    def getaccount(self, address):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getaccount", "params": ["'+str(address)+'"] }'
        return self.RPC(data)

    # getbalance with account is deprecated
    def getbalance(self, account='', minconf=1, includeWatchOnly=False):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getbalance", "params": ["",1] }'
        return self.RPC(data)

    # getnewaddress with account is deprecated
    def getnewaddress(self, account=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getnewaddress", "params": [] }'
        return self.RPC(data)

    # This is for use with raw transactions, NOT normal use.
    def getrawchangeaddress(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getrawchangeaddress", "params": [] }'
        return self.RPC(data)

    def getreceivedbyaddress(self, address, minconf=1):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getreceivedbyaddress", "params": ["'+str(address)+'", '+str(minconf)+'] }'
        return self.RPC(data)

    def gettransaction(self, txid, includeWatchOnly=False):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "gettransaction", "params": ["'+str(txid)+', '+str(includeWatchOnly)+'"] }'
        return self.RPC(data)

    def getunconfirmedbalance(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getunconfirmedbalance", "params": [] }'
        return self.RPC(data)

    #This call can take an increased amount of time to complete if rescan is true.
    def importaddress(self, address, label='', rescan=True):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "importaddress", "params": ["'+str(address)+'", "'+str(label)+'", '+str(rescan).lower()+'] }'
        return self.RPC(data)

    # This call can take an increased amount of time to complete if rescan is true.
    def importprivkey(self, privKey, label='', rescan=True):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "importprivkey", "params": ["UwibHKsYfiM19BXQmcUwAfw331GzGQK8aoPqqYEbyoPrzc2965nE", "testing", false] }'
        return self.RPC(data)

    def importwallet(self, path):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "importwallet", "params": ["'+str(path)+'"] }'
        return self.RPC(data)

    def keypoolrefill(self, newsize=100):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "keypoolrefill", "params": ['+str(newsize)+'] }'
        return self.RPC(data)

    def listaddressgroupings(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "listaddressgroupings", "params": [] }'
        return self.RPC(data)

    #See the lockunspent call to lock and unlock transactions for spending.
    def listlockunspent(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "listlockunspent", "params": [] }'
        return self.RPC(data)

    def listreceivedbyaddress(self, minconf=1, includeEmpty=False, includeWatchOnly=False):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "listreceivedbyaddress", "params": ['+str(minconf)+', '+str(includeEmpty).lower()+', '+str(includeWatchOnly).lower()+'] }'
        return self.RPC(data)

    def listsinceblock(self, blockhash='', targetconf=1, includeWatchOnly=False):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "listsinceblock", "params": ["'+str(blockhash)+'", '+str(targetconf)+', '+str(includeWatchOnly).lower()+'] }'
        return self.RPC(data)

    # listtransactions with account is deprecated
    def listtransactions(self, account="*", count=10, skip=0, includeWatchOnly=False):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "listtransactions", "params": ["*", '+str(count)+', '+str(skip)+', '+str(includeWatchOnly).lower()+'] }'
        return self.RPC(data)

    def listunspent(self, minconf=1, maxconf=9999999, addresses=[""]):
        addr_list = "[";
        for addr in addresses:
            # it seems Komodo rpc considers ' and " differently.. so instead of just str(addresses), have to do this
            addr_list += "\""+str(addr)+"\","
        if(len(addresses) > 0):
            addr_list = addr_list[:-1]
        addr_list += "]";
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "listunspent", "params": ['+str(minconf)+', '+str(maxconf)+', '+addr_list+'] }'
        return self.RPC(data)

    # See the listunspent and listlockunspent calls to determine local transaction state and info.
    def lockunspent(self, unlock=False, txid='', vout=0):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "lockunspent", "params": ['+str(unlock).lower()+', [{"txid":"'+str(txid)+'","vout":'+str(vout)+'}]] }'
        return self.RPC(data)

    def resendwallettransactions(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "resendwallettransactions", "params": [] }'
        return self.RPC(data)

    # account MUST be set to the empty string "" to represent the default account
    # incomplete: does not considers last two parameters: subtractFeeFromAmt and address
    def sendmany(self, account='', amounts={'':0}, minconf=1, comment='', subtractFeeFromAmt=[""], address=''):
        amount_list = "{";
        for amt in amounts:
            amount_list += "\""+amt+"\":"+str(amounts[amt])+","
        if(len(amounts) > 0):
            amount_list = amount_list[:-1]
        amount_list += "}"
        '''
        subtractFeeFrom_list = "[";
        for addr in subtractFeeFromAmt:
            subtractFeeFrom_list += "\""+str(addr)+"\","
        subtractFeeFrom_list = subtractFeeFrom_list[:-1]
        subtractFeeFrom_list += "]"
        '''
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "sendmany", "params": ["", ' + amount_list + ', ' + str(minconf) + ', "' + str(comment) + '"] }'
        #data = '{"jsonrpc": "1.0", "id":"curltest", "method": "sendmany", "params": ["", '+amount_list+', '+str(minconf)+', "'+str(comment)+'", '+subtractFeeFrom_list+', "'+str(address)+'"] }'
        return self.RPC(data)

    def sendtoaddress(self, address='', amount=0.0, comment='', comment_to='', subtractFeeFromAmt=False):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "sendtoaddress", "params": ["'+str(address)+'", '+str(amount)+', "'+str(comment)+'", "'+str(comment_to)+'", '+str(subtractFeeFromAmt).lower()+'] }'
        return self.RPC(data)

    # This method works only once per daemon start. It can't be used to change the pubkey that has already been set.
    def setpubkey(self, pubKey=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "setpubkey", "params": ["'+str(pubKey)+'"] }'
        return self.RPC(data)

    def settxfee(self, amount=0.0):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "settxfee", "params": ['+str(amount)+'] }'
        return self.RPC(data)

    def signmessage(self, address='', message=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "signmessage", "params": ["'+str(address)+'", "'+str(message)+'"] }'
        return self.RPC(data)

#################################################### Network Commands ##################################################################

    # node: ip:port
    # command: 'add' to add a node to the list, 'remove' to remove a node from the list, 'onetry' to try a connection to the node once
    def addnode(self, node='', command=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "addnode", "params": ["'+str(node)+'", "'+str(command)+'"] }'
        return self.RPC(data)

    def clearbanned(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "clearbanned", "params": [] }'
        return self.RPC(data)

    def disconnectnode(self, node=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "disconnectnode", "params": ["'+str(node)+'"] }'
        return self.RPC(data)

    # Nodes added via onetry are not listed here.
    def getaddednodeinfo(self, dns=False, node=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getaddednodeinfo", "params": ['+str(dns).lower()+', "'+str(node)+'"] }'
        return self.RPC(data)

    def getconnectioncount(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getconnectioncount", "params": [] }'
        return self.RPC(data)

    # This method is applicable only to the KMD main net.
    def getdeprecationinfo(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getdeprecationinfo", "params": [] }'
        return self.RPC(data)

    def getnettotals(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getnettotals", "params": [] }'
        return self.RPC(data)

    def getnetworkinfo(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getnetworkinfo", "params": [] }'
        return self.RPC(data)

    def getpeerinfo(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getpeerinfo", "params": [] }'
        return self.RPC(data)

    def listbanned(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "listbanned", "params": [] }'
        return self.RPC(data)

    def ping(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "ping", "params": [] }'
        return self.RPC(data)

    # argument ip(/netmask): the IP/subnet (see getpeerinfo for nodes ip) with an optional netmask (default is /32 = single ip)
    # command: use "add" to add an IP/subnet to the list, or "remove" to remove an IP/subnet from the list
    # bantime: indicates how long (in seconds) the ip is banned (or until when, if [absolute] is set). 0 or empty means the ban is using the default time of 24h, which can also be overwritten using the -bantime runtime parameter.
    # absolute: if set to true, the bantime must be an absolute timestamp (in seconds) since epoch (Jan 1 1970 GMT)
    def setban(self, ip='', command='', bantime=0, absolute=False):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "setban", "params": ["'+str(ip)+'", "'+str(command)+'", '+str(bantime)+', '+str(absolute).lower()+'] }'
        return self.RPC(data)

#################################################### Util Commands ##################################################################

    def createmultisig(self, number_required=1, keys=['']):
        key_list = "[";
        for addr in keys:
            # it seems Komodo rpc considers ' and " differently.. so instead of just str(keys), have to do this
            key_list += "\"" + str(addr) + "\","
        if(len(keys) > 0):
            key_list = key_list[:-1]
        key_list += "]";
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "createmultisig", "params": ['+str(number_required)+', '+str(key_list)+'] }'
        return self.RPC(data)

    def decodeccopret(self, scriptPubKey=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "decodeccopret", "params": ["'+scriptPubKey+'"] }'
        return self.RPC(data)

    # The value -1.0 is returned if not enough transactions and blocks have been observed to make an estimate
    def estimatefee(self, num_blocks=0):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "estimatefee", "params": ['+str(num_blocks)+'] }'
        return self.RPC(data)

    # The value -1.0 is returned if not enough transactions and blocks have been observed to make an estimate
    def estimatepriority(self, num_blocks=0):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "estimatepriority", "params": ['+str(num_blocks)+'] }'
        return self.RPC(data)

    def invalidateblock(self, block_hash=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "invalidateblock", "params": ["'+str(block_hash)+'"] }'
        return self.RPC(data)

    def reconsiderblock(self, block_hash=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "reconsiderblock", "params": ["'+str(block_hash)+'"] }'
        return self.RPC(data)

    def txnotarizedconfirmed(self, tx_id=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "txnotarizedconfirmed", "params": ["'+str(tx_id)+'"] }'
        return self.RPC(data)

    def validateaddress(self, address=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "validateaddress", "params": ["'+str(address)+'"] }'
        return self.RPC(data)

    def verifymessage(self, address='', signature='', message=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "verifymessage", "params": ["'+str(address)+'", "'+str(signature)+'", "'+str(message)+'"] }'
        return self.RPC(data)

    def z_validateaddress(self, address=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "z_validateaddress", "params": ["'+str(address)+'"] }'
        return self.RPC(data)

#################################################### Address Commands ##################################################################

    # needs to be tested
    def getaddressbalance(self, addresses=[""]):
        addr_list = "["
        for addr in addresses:
            addr_list += "\"" + str(addr) + "\","
        if(len(addresses) > 0):
            addr_list = addr_list[:-1]
        addr_list += "]"
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getaddressbalance", "params": [{"addresses": '+str(addr_list)+'}] }'
        return self.RPC(data)

    # needs to be tested
    def getaddressdeltas(self, addresses=[""], start=0, end=0, chainInfo=False):
        addr_list = "["
        for addr in addresses:
            addr_list += "\"" + str(addr) + "\","
        if(len(addresses) > 0):
            addr_list = addr_list[:-1]
        addr_list += "]"
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getaddressdeltas", "params": [{"addresses": '+str(addr_list)+',"start":'+str(start)+',"end":'+str(end)+',"chainInfo":'+str(chainInfo).lower()+'}]}'
        return self.RPC(data)

    def getaddressmempool(self, addresses=[""]):
        addr_list = "["
        for addr in addresses:
            addr_list += "\"" + str(addr) + "\","
        if(len(addresses) > 0):
            addr_list = addr_list[:-1]
        addr_list += "]"
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getaddressmempool", "params": [{"addresses": '+str(addr_list)+'}] }'
        return self.RPC(data)

    # needs to be tested
    def getaddresstxids(self, addresses=[""], start=0, end=0):
        addr_list = "["
        for addr in addresses:
            addr_list += "\"" + str(addr) + "\","
        if(len(addresses) > 0):
            addr_list = addr_list[:-1]
        addr_list += "]"
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getaddresstxids", "params": [{"addresses": '+str(addr_list)+', "start":'+str(start)+',"end":'+str(end)+'}] }'
        return self.RPC(data)

    # needs to be tested
    def getaddressutxos(self, addresses=[""], chainInfo=False):
        addr_list = "["
        for addr in addresses:
            addr_list += "\"" + str(addr) + "\","
        if(len(addresses) > 0):
            addr_list = addr_list[:-1]
        addr_list += "]"
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getaddressutxos", "params": [{"addresses": '+str(addr_list)+', "chainInfo": '+str(chainInfo).lower()+'}] }'
        return self.RPC(data)

    # getsnapshot requires -addressindex=1
    def getsnapshot(self, top=0):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getsnapshot", "params": ["'+str(top)+'"] }'
        return self.RPC(data)

#################################################### Control Commands ##################################################################

    def getinfo(self):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "getinfo", "params": [] }'
        return self.RPC(data)

    def help(self, command=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "help", "params": ["'+str(command)+'"] }'
        return self.RPC(data)

    def stop(self, command=''):
        data = '{"jsonrpc": "1.0", "id":"curltest", "method": "stop", "params": [] }'
        return self.RPC(data)
