using System;
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
            p.SectionD();

            Console.ReadKey();


        }
        public void Run()
        {
            this.ReadTextFile();
        }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:\\Users\\732136\\Beowulf\\Beowulf.txt"))
            {

                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {

                    Beowulf.Add(ln);

                }

                file.Close();
                counter = File.ReadLines("U:\\Users\\732136\\Beowulf\\Beowulf.txt").Count();
                Console.WriteLine($"File has {counter} lines.");

            }

        }
        public void SectionD()
        {
            int a = 0, b = 0, c = 0;

            foreach (var line in File.ReadAllLines("U:\\Users\\732136\\Beowulf\\Beowulf.txt"))
            {
                if (line.Contains("fare"))
                {
                    a++;
                }

            }
            foreach (var line in File.ReadAllLines("U:\\Users\\732136\\Beowulf\\Beowulf.txt"))
            {
                if (line.Contains("war") && line.Contains("fare"))
                {
                    b++;
                }

            }
            c = a - b;
            Console.WriteLine("lines which have war and see: " + c);
        }
        public void SectionC()

        {
            int a = 0;
            foreach (var c in File.ReadAllLines("U:\\Users\\732136\\Beowulf\\Beowulf.txt"))
            {
                if (c.Contains("sea") && c.Contains("fare"))
                {
                    a++;
                }

            }
            Console.WriteLine(" lines contain word sea and but not Fare:" + a);
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

