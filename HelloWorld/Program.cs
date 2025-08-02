// See https://aka.ms/new-console-template for more information

using System;

public class HelloWorld {
    public static bool isEven(int number)
    {
        return number % 2 == 0;
    }

    // Main Method
    public static void Main(string[] args)
    {

        // // "printing Hello World"
        // Console.WriteLine("Hello, World!");
        // int number = 5;
        // int anotherNumber = 10;
        //
        // Console.WriteLine("What is your name");
        // String name = Console.ReadLine();
        // Console.WriteLine(number * anotherNumber);
        // string age = Console.ReadLine();
        // Console.WriteLine(Convert.ToInt32(age));
        //
        // string firstName = "Olamide";
        // string lastName = "Sadiku";
        // string myName = $"My name is {firstName} {lastName}";
        // Console.WriteLine(myName);
        //
        // Console.WriteLine("My name is" + name);
        int[] numbers = { 10, 2, 3, 4, 5 };
        for (int count = 0; count < numbers.Length; count++)
        {
            if(numbers[count] % 2 == 0) Console.WriteLine(numbers[count]);
        }

        Console.WriteLine(isEven(10));
    }
}

