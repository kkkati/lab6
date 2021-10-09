using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string predlojenie = Console.ReadLine();
            string[] predlojenieArray = predlojenie.Split();
            string slovo = "";
            int l = 0;

            foreach (string s in predlojenieArray)
            {
                if (l< s.Length)
                {
                    l = s.Length;
                    slovo = s;
                }   
            }


            Console.Write("Самое длинное слово: {0}",slovo);
            Console.ReadKey();
        }
    }
}
