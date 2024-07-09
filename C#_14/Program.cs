using System;
using System.Reflection.PortableExecutable;

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
           
            /*for (int i = 0; i < readText.Length; i++)
            {
                if (char.IsPunctuation(readText[i]))
                   {
                     readText.Replace(readText[i], ' ');
                   }
            }
            Console.WriteLine(readText);
            */

            /*Char[] punct = new Char[] { '.', '?', '!', ',', ';', ':', '-', ' '};

            for (int i = 0; i < readText.Length; i++)
            {
                for (int j = 0; j < punct.Length; j++)
                {
                    if (readText[i] == punct[j])
                    {
                        string readText1 = readText.Replace(readText[i], ' ');
                    }
                }
            }*/


            //Console.WriteLine(readText.Trim(new Char[] {'.', '?', '!', ',', ';', ':', '-', ' '}));



            /*Dictionary<int, string> d = new Dictionary<int, string>();

            for (int i = 0; i < readText.Length; i++)
            {
                foreach (string line in readText.Split(" "))
                {
                    d.Add(i, line);
                }
            }

            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }*/
        }
    }
    }

