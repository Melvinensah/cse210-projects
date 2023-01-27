using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        Console.Write("Please enter your name ");
        string name = Console.ReadLine();
        string userName = PromptUserName(name);
        Console.WriteLine($"Good morning {name}");

        Console.Write("please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        int favoriteNumber = PromptUserNumber(number);
        Console.WriteLine($"Your favorite numbeer is {favoriteNumber}");
        
        Console.Write("please enter an integer: ");
        string userInteger = Console.ReadLine();
        int integer = int.Parse(userInteger);
        int squareNumber = SquareNumber(integer);
        Console.WriteLine($"The square of your integer is {squareNumber}");
        
        DisplayResult(userName, squareNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }

        static string PromptUserName(string username)
        {
            return username;
        }

        static int PromptUserNumber(int userNumber)
        {
            return userNumber;
        }

        static int SquareNumber(int integer)
        {
            int square = integer*integer;
            return square;
        }

        static void DisplayResult(string usersName, int userNumberSquared)
        {
            Console.WriteLine($"Your name is {usersName} and your squared  is {userNumberSquared}");
        }
    } 
}