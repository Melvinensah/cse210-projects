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
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
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