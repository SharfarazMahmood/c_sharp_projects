using System;

namespace c_sharp_projects
{
    class Program
    {
        static void Main(
            //string[] args
            )
        {

            /*
             *  string _name = "Sharfaraz";
            int _age = 1000;
            Console.WriteLine("First C# programm\n author: "+ _name);
            Console.WriteLine(" age:"+ _age);
            Console.WriteLine(Math.Sqrt(25.1));
            Console.Write("Enter a line: ");
            string input = Console.ReadLine();
            Console.WriteLine("given intput: "+ input);
            */
            /*
            string color, pluralNoun, cleb;
            Console.Write("Enter a color: ");
            color =  Console.ReadLine();


            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity name: ");
            cleb = Console.ReadLine();

            Console.WriteLine("Flowers are " + color);
            Console.WriteLine(pluralNoun+" are blue");
            Console.WriteLine("who is "+ cleb);*/

            // obj.GuessWhat();


            // Console.WriteLine(GetPow(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

            NewClass obj = new NewClass();

            obj.TryCatch();

            Console.ReadLine();
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }

    class NewClass
    {
        public NewClass() { }
        public void GuessWhat()
        {
            string scrtWord = "giraffe";
            string que = "Guess the word: ";
            string guessesWord;
            int guessCount = 0;

            do
            {
                Console.Write(que + "(attempt: " + guessCount + ") ");
                guessCount++;
                guessesWord = Console.ReadLine();
                que = "Sorry,  try again: ";
                if ((guessesWord.Trim() == scrtWord))
                {
                    Console.Write("You Gussed it !!");
                    break;
                }

            } while ((guessesWord.Trim() != scrtWord) && guessCount < 3);

            if ((guessesWord.Trim() != scrtWord))
            {
                Console.Write("Oho,  you have no more chance !! ");
            }
        }

        public void TryCatch()
        {
            try
            {
                Console.WriteLine(Convert.ToInt32(Console.ReadLine()) / Convert.ToInt32(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // throw;
            }
        }
    }

}
