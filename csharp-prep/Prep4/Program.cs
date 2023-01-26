using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;
        int total = 0;

        while (newNumber!=0)
        {
            Console.Write("enter a series of number. Enter 0 to quit");
            string userNumber = Console.ReadLine();  
            newNumber = int.Parse(userNumber); 

            if (newNumber !=0)
            {
                numbers.Add(newNumber);
            }
        }
        foreach(int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"the total is {total}");

        float listSize = numbers.Count;
        
        float average = total / listSize;

        Console.WriteLine($"the average is {average}");

        int maximum = numbers.Max();
        Console.WriteLine($"The maximum number is {maximum}");
    }

}