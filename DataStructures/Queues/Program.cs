using System;
using System.Collections.Generic;


namespace Queues // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> _line = new Queue<string>();
            Console.WriteLine("Type a name and press ENTER:");
            String lineName = Convert.ToString(Console.ReadLine());
            AddToLine(lineName, _line);

            bool addToLine = true;
            string yesNo;
            int checkValue;

            while (addToLine)
            {
                Console.WriteLine("\nMenu:\n1. Type 1 and press ENTER to add someone to the line \n2. Type 2 and press ENTER to remove the first person in line " +
                    "\n3. Type 3 and press ENTER to see the first person in line \n4. Type 4 and press ENTER to display the people in line \n5. Type 5 and press ENTER to quit:");

                yesNo = Console.ReadLine();

                if(int.TryParse(Convert.ToString(yesNo), out checkValue))
                {
                   checkValue = Convert.ToInt32(yesNo);
                } else
                {
                    Console.WriteLine("Invalid Entry. Displaying people in line instead.");
                    checkValue = 4;
                }

                switch (checkValue)
                {
                    case 1:
                        Console.WriteLine("Type a name and press ENTER:");
                        lineName = Console.ReadLine();
                        AddToLine(lineName, _line);
                        break;
                    case 2:
                        Console.WriteLine($"{RemoveFromLine(_line)} left the line");
                        break;
                    case 3:
                        Console.WriteLine($"{PeekAtQueue(_line)} is the first person in line.");
                        break;
                    case 4:
                        ShowPeopleLine(_line);
                        break;
                    case 5:
                        addToLine = false;
                        Console.WriteLine("Here's final list of people in line:");
                        ShowPeopleLine(_line);
                        break;
                    default:
                        Console.WriteLine("\nInvalid entry!");
                        break;
                }
            }
            Console.ReadKey();
        }

        public static void AddToLine(String line, Queue<string> _line)
        {
            _line.Enqueue(line);
            Console.WriteLine($"\"{line}\" is now waiting in line.");
        }

        public static string RemoveFromLine(Queue<string> _line)
        {
            return _line.Dequeue();
        }

        public static string PeekAtQueue(Queue<string> _line)
        {
            return _line.Peek();
        }

        public static void ShowPeopleLine(Queue<string> _line)
        {
            Console.WriteLine($"Number of people waiting in line: {_line.Count} \nList of people:");
            foreach (String line in _line)
            {
                Console.WriteLine(line);
            }
        }
    }
}