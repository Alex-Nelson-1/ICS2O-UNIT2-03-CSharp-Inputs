// Created by: Alex Nelson
// Created on: Oct 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        string name;
        int age;
        Console.WriteLine("This program shows a persons name as well as their age");
        Console.WriteLine("\nEnter your first name.");
        name = Console.ReadLine();
        Console.WriteLine("Enter your age.");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nYour info is: " + name + ", age " + age);
        Console.WriteLine("\nDone");
    }
}
