using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace ConsoleApp1
{
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
                p.SectionE();

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
                    Console.WriteLine("File has {counter} lines.");

                }

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

                Console.WriteLine(" Number of Words : " + Count);

            }
            public void SectionE()
            {

                StreamReader reader = new StreamReader("U:\\Users\\732136\\Beowulf\\Beowulf.txt");
                string read = reader.ReadToEnd();
                int number = 0;
                foreach (char letter in read)
                {
                    number++;
                }
                Console.WriteLine("total no. of letters after each word:  " + number);

            }


            public int FindNumberOfBlankSpaces(string line)
            {
                https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
                int countletters = 0;
                int countSpaces = 0;

                foreach (char c in line)
                {
                    if (char.IsLetter(c)) { countletters++; }

                    if (char.IsWhiteSpace(c)) { countletters++; }
                }
                return countSpaces;

            }


            public int FindNumberOfBlankSpaces6(string line)
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
}

    
