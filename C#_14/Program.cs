using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace C__14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\Kobzar.txt");
            string readText = sr.ReadToEnd();
            //Console.WriteLine(readText);
            sr.Close();

            string noPunctuationText = Regex.Replace(readText, @"[^\w\s]", "");
            // Console.WriteLine(noPunctuationText);

            // удаление всех переходов на след.строку
            string singleLineText = Regex.Replace(noPunctuationText, @"\s+", " ");
            // Console.WriteLine(singleLineText);

            // замена нескольких пробелов подряд на одинарный
            string normalizedText = Regex.Replace(singleLineText, @"\s{2,}", " ");
            //Console.WriteLine(normalizedText);
            
            Dictionary<string, int> d = [];

            foreach (string line in normalizedText.Split(" "))
            {
                if (line.Length > 3 && line.Length < 20)
                {
                    if (!d.ContainsKey(line))
                    {
                        d.Add(line, 1);
                    }
                    else
                    {
                        d[line] += 1;
                    }
                }
            }

            // упорядочить словарь по количеству слов
            var sort = d.OrderByDescending(x => x.Value);//По убыванию

            // Печать результатов подсчета слов
            Console.WriteLine("Всего количество слов: {0}", d.Count);

            foreach (var pair in sort)
            {
                Console.Write(pair.Key + " " + pair.Value + ", ");
            }
                
        }
    }
}

