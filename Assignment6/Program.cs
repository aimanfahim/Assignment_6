using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            namesList();
            sentenceParse();
            Console.Read();

        }

        //parse a sentence and provide character frequency
        static void sentenceParse()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            sentence = sentence.Replace(" ", string.Empty);
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char i in sentence)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }

            foreach (char i in sentence)
            {

                if (dict[i] != 0)
                {
                    Console.WriteLine(i + " | " + dict[i].ToString());
                    dict[i] = 0;
                }
            }


        }

        //print names as like facebook
        static void namesList()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Enter names");
            do
            {
                string name = Console.ReadLine();
                if (name != "")
                {
                    names.Add(name);
                }
                else
                {
                    break;
                }
            } while (true);

            for (int i = 0; i < names.Count; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.Write("Likes your post");
        }
    }
}