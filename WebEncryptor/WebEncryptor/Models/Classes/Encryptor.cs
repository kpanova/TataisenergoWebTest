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
            bool upper = false;
            StringBuilder newMsg = new StringBuilder();
            foreach(var sym in msg)
            {
                upper = false;
                if (Char.IsUpper(sym))
                {
                    upper = true;
                }
                if (DBConnector.getConnection().context.Symbols.isExsistsReplace(Char.ToLower(sym).ToString()))
                {
                    if (upper)
                    {
                        newMsg.Append(DBConnector.getConnection().context.Symbols.getReplace(Char.ToLower(sym).ToString()).ToUpper());
                    }
                    else
                    {
                        newMsg.Append(DBConnector.getConnection().context.Symbols.getReplace(sym.ToString()));
                    }
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