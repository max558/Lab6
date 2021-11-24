using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindom
{
    /*
     * Ввести с клавиатуры предложение. 
     * Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. 
     * Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
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
            //Нахождение последнего слова и его разворот
            string stEnd = "",
                lastReversSt="", 
                strCompar = "";
            ;
            foreach (string st in arrayStr)
            {
                stEnd = st;
                strCompar += st;
            }
            lastReversSt= new String(stEnd.Reverse().ToArray());

            //Cравнение по перевернутому последнему слову
            strCompar = strCompar.ToLower();
            lastReversSt = lastReversSt.ToLower();
            if (strCompar.StartsWith(lastReversSt))
            {
                Console.WriteLine("введенная строка является палиндромом");
            }
            else
            {
                Console.WriteLine("введенная строка НЕ является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
