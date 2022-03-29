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


            Console.WriteLine(GetPow(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

            Book obj = new Book("Nameless","John Doe", 12.65, "test");

            Console.WriteLine(obj.ToString());

            // Book.TryCatch();


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

    class Book
    {
        public string title;
        public string author;
        public double price;
        private string rating;

        public Book() { }

        public Book(string title, string author, double price, string rating) {
            this.title = title;
            this.author = author;
            this.price = price;
            Rating = rating;
        }

        public string Rating
        {
            get { return rating; }

            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "G" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
        public virtual void GuessWhat()
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

        static public void TryCatch()
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

        public  override string ToString()
        
        {
            return title + " " + author + " " + rating + " " + price;
        }
    }

    class HistoryBook: Book
    {
        public override void GuessWhat()
        {
            base.GuessWhat();
        }
    }

}
