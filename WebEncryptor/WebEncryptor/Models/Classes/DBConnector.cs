using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebEncryptor.Models.Classes
{
    public class DBConnector
    {
        public EncryptorContext context { get; private set; }
        private static DBConnector connection;
        private DBConnector()
        {
            if (context == null)
            {
                context = new EncryptorContext();
            }
        }
        public void createTables()
        {
            if (context.Database.Exists())
            {
                context.Symbols.generateEncryptTable(10);
            }
            else
            {
                context.Database.Create();
                context.Messages.Create();
                context.Symbols.Create();
                context.Symbols.generateEncryptTable(10);
            }
        }

        public static DBConnector getConnection()
        {
            if (connection == null)
                connection = new DBConnector();
            return connection;
        }
        
        
    }
}