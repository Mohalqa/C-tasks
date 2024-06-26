using System;
using System.Collections.Specialized;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
         * 
         * Task1 Orange C#
         * 
         * */

        ///////////Q1//////////////////////

        string name;
        Console.WriteLine("Please enter your string:");
        name = Console.ReadLine(); 
        Console.WriteLine("You entered: " + name);


        Console.WriteLine("***************************************************************");
        ///////////Q2//////////////////////
        double myDouble = 10.5;
        string myString = "Hello, World!";
        char myChar = 'A';
        bool myBool = true;
        int myInt = 42;
        const string myConst = "This is a constant";
        Console.WriteLine("Double: " + myDouble);
        Console.WriteLine("String: " + myString);
        Console.WriteLine("Char: " + myChar);
        Console.WriteLine("Bool: " + myBool);
        Console.WriteLine("Int: " + myInt);
        Console.WriteLine("***************************************************************");
        ///////////Q3//////////////////////
        string[] car = { "Toyota", "Honda", "BMW", "Mercedes" };

        // Print all the cars
        Console.WriteLine("Cars in the array:");
        foreach (string carName in car)
        {
            Console.WriteLine(carName);
        }
        Console.WriteLine("The length of the car array is: " + car.Length);
        Console.WriteLine("***************************************************************");
        ///////////Q4//////////////////////
        string firstName;
        string lastName;
        int yearOfBirth;
        Console.Write("Input your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Input your last name: ");
        lastName = Console.ReadLine();
        Console.Write("Input your year of birth: ");
        yearOfBirth = int.Parse(Console.ReadLine());
        Console.WriteLine($"{firstName} {lastName} {yearOfBirth}");
        Console.WriteLine("***************************************************************");
        ///////////Q5//////////////////////




    }
}