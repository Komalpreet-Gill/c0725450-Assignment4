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
        //this is my report:

        //How many lines in total are there in the file:  4016

        //How many WORDS are there in the file: 34573

        //Line numbers of the lines which contain BOTH of these words:
        //Sea and Fare(cover both upper and lower case)
        //the numbers are : 10

        //Line numbers of the lines which contain the word:  Fare
        //Without the word: War

        //14

        //Average number of letters per word returned as a float

        //1.45995429959795

        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
            string text = System.IO.File.ReadAllText("U:/Users/725450/C0725450-Assignment4/Beowulf.txt");
            p.FindNumberOfBlankSpaces(text);
            p.ProcessArrayList();
            p.ProcessArrayList1();
            p.FindNumberOfWords(text);
            p.AverageNumberOfLetters(text);

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
            Console.WriteLine("Number of letters: " + countletters);
            return countletters;
        }
        public int FindNumberOfWords(string x)
        {
            int result = 0;

            //Trim whitespace from beginning and end of string
            x = x.Trim();

            //Necessary because foreach will execute once with empty string returning 1
            if (x == "")
                return 0;

            //Ensure there is only one space between each word in the passed string
            while (x.Contains("  "))
                x = x.Replace("  ", " ");

            //Count the words
            foreach (string y in x.Split(' '))
                result++;

            Console.WriteLine("Result is " + result);
            return result;

        }

        public double AverageNumberOfLetters(string text)
        {
            
            double average = ((text.Length - FindNumberOfBlankSpaces(text)) / (float)FindNumberOfWords(text));
            Console.WriteLine("Average is " + average);
            return average;
        }

        public void ProcessArrayList()
        {
            int LineNumber = 0;
            foreach (var line in Beowulf)
                
            {
                
                if (!ContainWord(line.ToString().ToLower(), "war") && ContainWord(line.ToString().ToLower(), "fare"))
                {
                    Console.WriteLine(line);
                    Console.WriteLine("Line number is {0}", LineNumber);
                    LineNumber++;
                }
            }
            Console.WriteLine(LineNumber);
        }

        public void ProcessArrayList1()
        {
            int LineNumber = 0;
            foreach (var line in Beowulf)

            {

                if (ContainWord(line.ToString().ToLower(), "sea") && ContainWord(line.ToString().ToLower(), "fare"))
                {
                    Console.WriteLine(line);
                    Console.WriteLine("Line number is {0}", LineNumber);
                    LineNumber++;
                }
            }
            Console.WriteLine(LineNumber);
        }

        public bool ContainWord(string line, string Word)
        {
            if(line.Contains(Word) == true)
            {
                return true;
            }
            return false;
        }

    }
}
