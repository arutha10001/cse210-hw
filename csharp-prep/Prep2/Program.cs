using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int last_digit = (percent % 10);

        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }


        if (percent >= 97)
        {
            sign = "+";
        }


        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}