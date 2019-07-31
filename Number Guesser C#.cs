using System;

//Namespace 
namespace NumberGuesser
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {   
            //Run GetAppInfo function 
            GetAppInfo();
            GetUserInfo();


            while (true)
            {

                //Make correct number random
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess variable
                int guess = 0;

                //ask user to guess number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //Makes sure input is an integer
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an integer between 1 and 10");
                        continue;
                    }

                    //parse input string to integer and put it to guess variable
                    guess = Int32.Parse(input);

                    //Match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Please try again!");

                        continue;
                    }
                }

                //print success message
                PrintColorMessage(ConsoleColor.Green, "Congrats!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if(answer == "N"){
                    return;
                }
            }

        }

        static void GetAppInfo() {
            //set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Garrett Kent";

            //Changes text to yellow
            Console.ForegroundColor = ConsoleColor.Yellow;

            //App info header 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset color to original
            Console.ResetColor();
        }

        static void GetUserInfo() {
            //Ask user name
            Console.WriteLine("What is your name?");

            //store users name in variable
            string inputName = Console.ReadLine();

            //welcomes the new user
            Console.WriteLine("Hello {0}, Let's play a game...", inputName);
        }

        //print color message
        static void PrintColorMessage(ConsoleColor color, string message){
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }

    }
}
