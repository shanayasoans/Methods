/*
 Author: Shanaya Soans 
 Date: 02/10/20
 Comments: This C# console application code demonstartes the use of Methods
*/

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();
            PrintName(name);
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
        }
    }
}
