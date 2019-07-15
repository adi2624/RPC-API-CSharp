using System;
using System.Collections.Generic;

namespace Blockchain
{
    public partial class WebRequestPostExample
    {
        
        /*
        
            CONTROL COMMANDS

         */

        /*
        The getinfo method returns an object containing various state info
        :return: JSON string conataining wallet state and network state info
         */
        public string GetInfo(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("getinfo","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
         The help method lists all commands, or all information
        for a specified command
        :param command: (string, optional) the command requiring assistance
        :return: "help"	(JSON string) the command requiring assistance
         */
        public string Help(WebRequestPostExample httpInstance,string command)
        {
            string json = httpInstance.CreateJsonRequest("help","[" + "\"" + command + "\"" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

        /*
        The stop method instructs the coin daemon to shut down.
        :return: JSON string: Komodo server stopping
         */
        public string Stop(WebRequestPostExample httpInstance)
        {
            string json = httpInstance.CreateJsonRequest("stop","[" + "]" );
            string result = CallHttpRequest(json);
            return result;
        }

       
    }
}