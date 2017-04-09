using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpectoCMD
{
    public class SpectoCMDCore : MonoBehaviour
    {
        public string oauth;
        public string nickName;
        public string channelName;
        private string server = "irc.twitch.tv";
        private int port = 6667;
        
        public class MsgsEvent : UnityEngine.Events.UnityEvent<string> { } //this class inherits from unity events, to invoke recived msgs into a background callback

        public MsgsEvent Streamedmessage = new MsgsEvent(); //creating an instance of the class 
        private Queue<string> recivedCommands = new Queue<string>(); // the Queue contianing the commands
        private Queue<string> commandMsgs = new Queue<string>(); // containing chat command msgs such as ping and bong and simmliar commadns


    }
}
