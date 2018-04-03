using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEncryptor
{
    public class Message
    {
        public Message() { }
        public Message(string oldMessage)
        {
            this.oldMessage = oldMessage;
            Date = DateTime.Now;
        }
        public int MessageID
        {
            get; set;
        }

        public string oldMessage
        {
            get; set;
        }

        public System.DateTime Date
        {
            get; set;
        }
    }

    public class Symbol
    {
        public Symbol() { }

        public Symbol(string oldSymbol, string newSymbol)
        {
            this.oldSymbol = oldSymbol;
            this.newSymbol = newSymbol;
        }
        public int SymbolID
        {
            get; set;
        }

        public string oldSymbol
        {
            get; set;
        }

        public string newSymbol
        {
            get; set;
        }
    }
}
