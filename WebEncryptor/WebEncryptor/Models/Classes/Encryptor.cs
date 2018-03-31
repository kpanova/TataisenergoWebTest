using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using WebEncryptor.Interfaces;

namespace WebEncryptor.Classes
{
    public class Encryptor : IEncryptor
    {
        Dictionary<char, char> encDictionary = new Dictionary<char, char>
        {
            {'а', 'н'},
            {'б', 'к'},
            {'в', 'ы'}
        };
        
        string IEncryptor.Encrypt(string msg)
        {
            StringBuilder newMsg = new StringBuilder();
            foreach(var sym in msg)
            {
                if (encDictionary.ContainsKey(sym))
                {
                    newMsg.Append(encDictionary[sym]);
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