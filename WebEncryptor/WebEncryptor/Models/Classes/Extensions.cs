using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebEncryptor.Models.Classes
{
    public static class Extensions
    {
        public static void writeToTable(this DbSet<Symbol> table)
        {
            try
            {
                if (!DBConnector.getConnection().context.Symbols.Any())
                {
                    table.Add(new Symbol("а", "н"));
                    table.Add(new Symbol("б", "к"));
                    table.Add(new Symbol("в", "у"));
                }
            }
            catch (Exception ex)
            {
            }
        }
        public static bool isExsistsReplace(this DbSet<Symbol> Symbols, string symbol)
        {

            Symbols.Load();
            return Symbols.ToList().Where(x => x.oldSymbol.Equals(symbol)).Count() > 0;
        }

        public static string getReplace(this DbSet<Symbol> Symbols, string symbol)
        {
            Symbols.Load();
            return Symbols.ToList().Where(x => x.oldSymbol.Equals(symbol)).FirstOrDefault().newSymbol;
        }
    }
}