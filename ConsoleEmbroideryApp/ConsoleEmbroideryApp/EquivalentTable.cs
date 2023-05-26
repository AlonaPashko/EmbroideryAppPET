using ConsoleEmbroideryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmbroideryApp
{
    internal class EquivalentTable : IEquivalentTable
    {
        public Dictionary<string, string> Table { get; set; }

        public EquivalentTable() 
        {
            Table = new Dictionary<string, string>();
        }
        public EquivalentTable(Dictionary<string, string> table)
        {
            Table = table;
        }
        public override string ToString()
        {
            return Print.PrintDictionary(Table);
        }
    }
}
