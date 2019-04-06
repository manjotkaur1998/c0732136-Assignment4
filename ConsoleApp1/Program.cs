﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            p.ReadTextFile();
            p.SectionC();

            Console.ReadKey();


        }
        public void Run()
        {
            this.ReadTextFile();
        }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:\\Users\\732136\\Beowulf\\Beowulf.tx"))
            {

                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {

                    Beowulf.Add(ln);

                }

                file.Close();
                counter = File.ReadLines("U:\\Users\\732136\\Beowulf\\Beowulf.tx").Count();
                Console.WriteLine($"File has {counter} lines.");

            }
        }
        public void SectionC()

        {
            int a = 0;
            foreach (var c in File.ReadAllLines("assignment.txt"))
            {
                if (c.Contains("sea") && c.Contains("fare"))
                {
                    a++;
                }

            }
            Console.WriteLine("Total number of lines which contains word sea and Fare:" + a);
        }

        public void ReadTextFile()
        {

            var reader = new StreamReader("U:\\Users\\732136\\Beowulf\\Beowulf.txt");
            string script = reader.ReadToEnd();

            var text = script.Trim();
            int Count = 0, index = 0;

            while (index < text.Length)
            {

                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                Count++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine(" Number of Words are " + Count);

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
                    countletters++;
                }
            }
            return countSpaces;

        }






    }

}

