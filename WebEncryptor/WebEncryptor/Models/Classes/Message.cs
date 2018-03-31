using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebEncryptor.Interfaces;

namespace WebEncryptor.Classes
{
    public class Message
    {
        public string oldMessage { get; private set; }
        public string encryptedMessage { get; private set; }
        public DateTime getDate { get; private set; }
        IEncryptor encrypt;
        public Message(string msg)
        {
            oldMessage = msg;
            getDate = DateTime.Now;
            encrypt = new Encryptor();
            encryptedMessage = encrypt.Encrypt(oldMessage);
        }
        public string getEncryptedMsg()
        {
            return "\n" + encryptedMessage;
        }
    }

}