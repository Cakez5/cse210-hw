using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First name? ");
        String First = Console.ReadLine();
        Console.Write("What is your Last name? ");
        String Last = Console.ReadLine();
        Console.Write($"Your name is {Last}, {First} {Last}.");
    }
}