using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int guess = -1;

        
        while(guess != magicNumber)
        {
            Console.Write("what is the magic number? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            
            if (guess < magicNumber)
            {
                Console.WriteLine("go higher");
                
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("go lower");
            }
       
            else
            {
                    Console.WriteLine("conagratulations your guess is right");
            }
        }
    }
}