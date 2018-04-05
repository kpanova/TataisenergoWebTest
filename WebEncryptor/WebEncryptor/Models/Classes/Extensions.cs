using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Text;

namespace WebEncryptor.Models.Classes
{
    public static class Extensions
    {
        public static void generateEncryptTable(this DbSet<Symbol> table, int shift)
        {
            try
            {
                if (!DBConnector.getConnection().context.Symbols.Any())
                {
                    char[] oldRuSym = Enumerable.Range(0, 32).Select((x, i) => (char)('а' + i)).ToArray();
                    char[] oldEngSym = Enumerable.Range(0, 25).Select((x, i) => (char)('a' + i)).ToArray();
                    table.addNewSymbols(shift, oldRuSym);
                    table.addNewSymbols(shift, oldEngSym);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private static void addNewSymbols(this DbSet<Symbol> table, int shift, char[] oldSym)
        {
                    int j = shift;
                    foreach (var old in oldSym)
                    {
                        table.Add(new Symbol(old.ToString(), oldSym[j].ToString()));
                        j++;
                        if (j == oldSym.Count())
                        {
                            j = 0;
                        }
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