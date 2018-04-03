using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace WebEncryptor
{
    public class EncryptorContext : DbContext
    {
        public EncryptorContext() : base("EncryptedMsgesDB5")
        {
        }

        public DbSet<Message> Messages
        {
            get;
            set;
        }
        
        public DbSet<Symbol> Symbols
        {
            get;
            set;
        }

        
    }
}