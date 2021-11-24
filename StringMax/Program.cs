using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMax
{
    /*
     * Ввести с клавиатуры предложение. 
     * Предложение представляет собой слова, разделенные пробелом. 
     * Знаки препинания не используются. 
     * Найти самое длинное слово в строке.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            
            Console.WriteLine("Введите строку:");
            s = Console.ReadLine();
            Console.WriteLine();

            string[] arrayStr = s.Split(' ');
            int stLen = 0;
            string stMax = "";
            foreach (string st in arrayStr)
            {
                if (stLen<st.Length)
                {
                    stLen = st.Length;
                    stMax = st;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении {0}, его длина составляет {1} симв.",stMax,stLen);
            Console.ReadKey();
        }
    }
}
