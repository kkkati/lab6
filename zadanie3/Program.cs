using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();
            int i = 0;
            int j = 0;
            int a = 0;

            for (i=0; i<stroka.Length; i++)
            {
                if (stroka[i] == '{')
                {
                    j++;
                    if (j==1)
                    {
                        a = i;
                    }
                }
                else 
                {
                    if (stroka[i] == '}' && j != 0)
                    {
                        j--;
                        if (j==0)
                        {
                            stroka = stroka.Remove(a, i - a + 1);
                        }
                    }    
                }
            }
           

            
            Console.WriteLine(stroka);


            Console.ReadKey();
        }

       
    }
}
