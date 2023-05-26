using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmbroideryApp
{
    public static class Print
    {
        public static string line;

        static Print()
        {
            line = "\n";
        }

        public static string PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                line += item + "\n";
            }
            return line;
        }
        public static string PrintDictionary(Dictionary<string, string> dict)
        {
            foreach (var item in dict)
            {
                line += item.Key + " - " + item.Value + "\n";
            }
            return line;
        }
    }
}