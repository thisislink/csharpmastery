using System;
using System.Collections.Generic;

namespace Stacks // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> _books = new Stack<string>();
            Console.WriteLine("Type the name of a book and press ENTER:");
            String bookName = Convert.ToString(Console.ReadLine());
            AddToStack(bookName, _books);

            bool addMoreBooks = true;
            String yesNo = "";
            
            while (addMoreBooks)
            {
                Console.WriteLine("\nMenu:\n1. Type A and press ENTER to add another book \n2. Type R and press ENTER to delete the last book added " +
                    "\n3. Type L and press ENTER to see the last book added \n4. Type D and press ENTER to display the entire list of books \n5. Type Q and press ENTER  to quit:");
                yesNo = Console.ReadLine();

                switch(yesNo.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Type the name of a book and press ENTER:");
                        bookName = Console.ReadLine();
                        AddToStack(bookName, _books);
                        break;
                    case "D":
                        Console.WriteLine("Your current list of books:");
                        DisplayAllBooks(_books);
                        break;
                    case "R":
                        Console.WriteLine(PopFromStack(_books));
                        break;
                    case "L":
                        Console.WriteLine(PeekAtStack(_books));
                        break;
                    case "Q":
                        addMoreBooks = false;
                        Console.WriteLine("Here's your final list of books:");
                        DisplayAllBooks(_books);
                        break;
                    default: 
                        Console.WriteLine("\nInvalid entry!");
                        break;
                }
            }
            Console.ReadKey();
        }

        public static void AddToStack(String book, Stack<string> _books)
        {
            _books.Push(book);
            Console.WriteLine($"\"{book}\" added to the list.");
        }

        public static string PopFromStack(Stack<string> _books)
        {
            return _books.Pop();
        }

        public static string PeekAtStack(Stack<string> _books)
        {
            return _books.Peek();
        }

        public static void DisplayAllBooks(Stack<string> _books)
        {
            foreach(String book in _books)
            {
                Console.WriteLine(book);
            }            
        }
    }
}