using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C0725450_Assignment4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
            string text = System.IO.File.ReadAllText("U:/Users/725450/C0725450-Assignment4/Beowulf.txt");
            p.FindNumberOfBlankSpaces(text);
            p.FindNumberOfWords(text);

        }

        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            //Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader("U:/Users/725450/C0725450-Assignment4/Beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);

                    counter++;
                }

                file.Close();
                Console.WriteLine($"File has {counter} lines.");

                
            }
        }

        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }
                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;
                    
                }
                
            }
            Console.WriteLine("Number of Blank Spaces: "+countSpaces);
            Console.WriteLine("Number of words: " + countletters);
            return countSpaces;
        }

        public int FindNumberOfWords(string line)
        {

            int countlines1 = 0;
            int countlines2 = 0;
            if (line.Contains("Sea"))
            {
                countlines1++;
            }
            if (line.Contains("Fare"))
            {
                countlines2++;
            }

            int countlines = countlines1 + countlines2;
            Console.WriteLine("The lines that contains Sea and Fare are " + countlines);
            return countlines;
        }


    }
}
