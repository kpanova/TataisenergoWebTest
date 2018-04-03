using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using WebEncryptor.Interfaces;
using WebEncryptor.Models.Classes;

namespace WebEncryptor.Classes
{
    public class Encryptor : IEncryptor
    {
        static Dictionary<char, char> encDictionary
        {
            get;
            set;
        }
        
        string IEncryptor.Encrypt(string msg)
        {
            StringBuilder newMsg = new StringBuilder();
            foreach(var sym in msg)
            {
                if (DBConnector.getConnection().context.Symbols.isExsistsReplace(sym.ToString()))
                {
                    newMsg.Append(DBConnector.getConnection().context.Symbols.getReplace(sym.ToString()));
                }
                else
                {
                    newMsg.Append(sym);
                }
            }
            return newMsg.ToString();
        }
    }
}