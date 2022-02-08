using System;

namespace Stacks // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        Stack<string> _books = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Type the name of a book and press ENTER:");
            String bookName = Console.ReadLine();
            AddToStack(bookName);

            bool addMoreBooks = true;
            String yesNo = "";
            
            while (addMoreBooks)
            {
                Console.WriteLine("\nWant to add more books?:");
                Console.ReadLine();

                switch(yesNo.ToUpper())
                {
                    case "Y":
                        
                        break;
                        case "N":
                        break;
                        default: 
                            Console.WriteLine("\nInvalid entry!");
                            break;
                }
            }
            Console.ReadKey();
        }

        public static void AddToStack(String book)
        {
            _books.Push(book);
        }

        public static string PopFromStack(String book)
        {
            return _books.Pop();
        }

        public static string PeekAtStack(String book)
        {
            return _books.Peek();
        }

        public string[] DisplayAllBooks()
        {
            return _books.ToArray();
        }
    }
}