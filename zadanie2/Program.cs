using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string predlojenie = Console.ReadLine();
            string stroka = "";
            string[] predlojenieArray = predlojenie.Split();

            //избавляемся от заглавных и пробелов
            foreach (string s in predlojenieArray)
            {
                stroka += s.Substring(0).ToLower();
            }

            //разбиваем строку на массив символов и переворачиваем массив
            char[] bukva = stroka.ToCharArray();
            Array.Reverse(bukva);
            string stroka2 = String.Join("",bukva);


            //сравниваем строки
            if (stroka==stroka2)
            {
                Console.Write("Предложение является палиндромом");
            }
            else
            {
                Console.Write("Предложение не является палиндромом");
            }
            
            Console.ReadKey();
        }
    }
}
