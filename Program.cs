using System;

namespace NumberGuesser
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser(); 

            while(true)
            {
                  

            //Set correct number
            //int correctNumber = 7;

            //Create a random object
            Random random = new Random();
            int correctNumber = random.Next(1, 10);

            //init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                string input = Console.ReadLine();

                //Making sure that it is a number
                if (!int.TryParse(input, out guess))
                {
                
                    PrintColorMessage(ConsoleColor.Red,"Please enter an actual number!");
                }  

                //match guess to correct number
                if(guess != correctNumber)
                {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number!");


                        continue;

                }
            }
                PrintColorMessage(ConsoleColor.Yellow, "You guessed right!");


                Console.WriteLine("Play again? [Y or N]");
            string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                    {
                    return;
                }
                return;

            }


        }

        static void GetAppInfo()
        {
            //Set variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Chihiro Noad";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

