using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        }

        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            //Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader("Desktop/beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine())!=null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine("")
            }
        }
    }
