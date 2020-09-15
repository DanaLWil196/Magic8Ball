using System;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static Random randomObject = new Random();
        public static void Main(string[] args)
        {
            QuestionLoop();
        }
        static string GetQuestionFromUser()
        {
            Console.WriteLine("What question do you have?");
            string questionString = Console.ReadLine();
            return questionString;
        }
        static void QuestionLoop()
        {
            while (true)
            {
                int numberOfSecondsToSleep = randomObject.Next((5) + 1);
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                string questionString = GetQuestionFromUser();

                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                if (questionString.ToLower() == "ninja")
                {
                    Console.WriteLine("Shhh... we don't speak of the invisible");
                    break;
                }
                Console.WriteLine("Hmmm... Let me think...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);
                int randomNumber = randomObject.Next(10);
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Bad Idea!");
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("That's a mysteru for the ages!");
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("I would make donuts instead.");
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Your teacher is a nija. Be nice.");
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("42. It's the answer to everything.");
                            break;
                        }
                    case 7:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Stop asking question and make me a pizza.");
                            break;
                        }
                    case 8:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Maybe");
                            break;
                        }
                    case 9:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("This isn't Canada, speak English.");
                            break;
                        }
                }
            }
        }
    }
}
