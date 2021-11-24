using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDel
{
    /*
     * Дана строка S. 
     * Из строки требуется удалить текст, заключенный в фигурные скобки. 
     * В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
     * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Программа должна удалять данные строки только те, которые заключены в фигурные скобки, 
             * т.е должны встретить одинаковое количество открывающих и закрывающих скобок 
             * Скобки тоже удаляются
             */
            string s = "",
                strFinish = "";
            Console.WriteLine("Введите строку:");
            s = Console.ReadLine();
            Console.WriteLine();
            string[] arrayStr = s.Split('{');
            if (arrayStr.Length > 1)
            {
                foreach (string a in arrayStr)
                {
                    string[] arrayStrElem = a.Split('}');
                    if (arrayStrElem.Length > 1)
                    {
                        //Не берем (удаляем), только данные до первой }, остальные записываем, поскольку не было открывающих {
                        for (int i = 1; i < arrayStrElem.Length; i++)
                        {
                            strFinish += ((i > 1) ? "}" : "") + arrayStrElem[i]; // Записываем } в случае если } больше чем открывающих
                        }
                    }
                    else
                    {
                        //Проверка на пустой элемент, т.к. может случиться ситуация, когда не будет закрывающей скобки, а как следствие эту скобку нужно оставить в строке
                        strFinish += ((strFinish.Length > 0) ? "{" : "") + a;
                    }
                }
            }
            else
            {
                strFinish = s;
            }

            Console.WriteLine(strFinish);
            Console.ReadKey();
        }
    }
}
