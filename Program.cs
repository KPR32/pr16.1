using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace prak16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //StreamWriter sw1 = new StreamWriter("t1.txt");
            //string s1 = "Слон и моська. Слон повстречал моську и СЛОН …";
            //Console.WriteLine(s1);
            //sw1.WriteLine(s1);
            //sw1.Close();
            //StreamReader sr = new StreamReader("t1.txt");
            //string str = sr.ReadToEnd();
            //sr.Close();
            //str = str.ToLower();
            //string[] word = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Console.Write("Введите слово для поиска: ");
            //string p = Console.ReadLine();
            //var slovo = word.SkipWhile(x => x == p);
            //var slovoCount = from k in word where k.Contains(p.ToLower()) select k;
            //if (p.Length != 0)
            //{
            //    if (slovo.Count() > 0)
            //    {
            //        Console.WriteLine($"Были найдены {slovoCount.Count()} вхождения(ий) слова '{p}'");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Такое слово не найдено");
            //    }
            //}
            //else
            //    Console.WriteLine("Ничего не введено");


            //4            
            StreamWriter sw = new StreamWriter("3.txt");
            string s1 = "Россия 146023195";
            string s2 = "Сингапур 6058739";
            string s3 = "США 335028178";
            string s4 = "Франция 65790152";
            string s5 = "Индия 1408044253";
            string s6 = "Бразилия 215681045";
            string s7 = "Египет 105838455";            
            sw.WriteLine(s1);
            sw.WriteLine(s2);
            sw.WriteLine(s3);
            sw.WriteLine(s4);
            sw.WriteLine(s5);
            sw.WriteLine(s6);
            sw.WriteLine(s7);
            sw.Close();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine("Введите число населения");
            string n = Console.ReadLine();
            Console.WriteLine("Вывод");            
            Console.WriteLine($"Упорядоченный список стран, у которых численность больше {n}:");
            Queue<Countries> myQueue = new Queue<Countries>();
            StreamReader sr = new StreamReader("3.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] lines = line.Split(' ');
                Countries countrie = new Countries();
                countrie.countrie = lines[0];
                countrie.population = int.Parse(lines[1]);
                myQueue.Enqueue(countrie);
            }
            sr.Close();
            IEnumerable<Countries> countries = myQueue.OrderBy(x => x.countrie.Length).ThenBy(x => x.countrie).Where(x => x.population > int.Parse(n));
            foreach (var item in countries)
            {
                Console.WriteLine($"{item.countrie} {item.population}");
            }
        }
    }
}
