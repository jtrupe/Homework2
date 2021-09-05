/// Homework 2 Project 2		
///
/// @author: Julian Trupe
/// Date:  September 5, 2021
///
/// Problem Statement: Ask user for the temmperature in degrees Fahrenheit, convert to Celsius
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user to enter a temperature in Fahrenheit
/// 3) Convert temmperature to Celsius
/// 4) Print the converted temperature
/// 

using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //print welcome messages
            Console.WriteLine("Hello!");
            Console.WriteLine("I will convert the temperature fromm Fahrenheit to Celsius");

            //declare variables
            float degreesF, degreesC;

            //get temmperature from user, convert to Fahrenheit
            Console.WriteLine("Please enter a temperature in Fahrenheit");
            degreesF = float.Parse(Console.ReadLine());
            degreesC = 5*(degreesF - 32) / 9;

            //print converted temperature
            Console.WriteLine("The converted temmperature is " + Math.Round(degreesC,1) + " degrees Celsius");
        }
    }
}
