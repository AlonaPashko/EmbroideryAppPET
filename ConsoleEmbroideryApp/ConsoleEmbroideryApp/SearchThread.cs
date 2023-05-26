
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileOperationsLibrary;

namespace ConsoleEmbroideryApp
{
    internal static class SearchThread
    {
        public static void Search(ThreadsList threads, string type)
        {
            if (threads == ThreadsList.DMC)
            {
                string path = @"..\\..\\..\\Files\\dmc.txt";
                PrintAnswer(SearchLogic(type, path));
            }
            if (threads == ThreadsList.Gamma)
            {
                GammaSearchLogic(type);
            }
        }
        private static bool SearchLogic(string type, string path)
        {
            FileReader reader = new FileReader(path);
            List<string> threadsList = reader.ReadExpression();

            foreach (string thread in threadsList)
            {
                if (thread.Contains(type))
                {
                    return true;
                }
            }
            return false;
        }
        private static void GammaSearchLogic(string type)
        {
            string path = @"..\\..\\..\\Files\\gamma_in_box.txt";
            string secondpath = @"..\\..\\..\\Files\\gamma.txt";
            PrintAnswer(SearchLogic(type, path));
            Console.Write(" in the box");
            Console.WriteLine();
            PrintAnswer(SearchLogic(type, secondpath));
            Console.Write(" in the bag");
        }
        public static void PrintAnswer(bool result)
        {
            if (result == true) Console.Write("The thresd is exist");
            else Console.Write("The thread doesn't exist");
        }
        public static void PrintList(string path)
        {
            FileReader reader = new FileReader(path);
            List<string> list = reader.ReadExpression();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

    }
}
