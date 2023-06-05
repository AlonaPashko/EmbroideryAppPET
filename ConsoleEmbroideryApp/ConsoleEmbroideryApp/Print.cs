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

        public static string PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                line += item + "\n";
            }
            return line;
        }
        public static string PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
        {
            foreach (var item in dict)
            {
                line += item.Key?.ToString() + " - " + item.Value?.ToString() + "\n";
            }
            return line;
        }
    }
}