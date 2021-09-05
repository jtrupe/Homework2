/// Homework 2 Project 1		
///
/// @author: Julian Trupe
/// Date:  September 5, 2021
///
/// Problem Statement: Ask user for their first and last name, convert full name to Pig Latin
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user to enter their first and last name
/// 3) Convert names to Pig Latin using custom method
/// 4) Display translated name to user
/// 

using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //print welcome messages
            Console.WriteLine("Hello!");
            Console.WriteLine("I will convert your name to Pig Latin!");

            //declare variables
            string firstName, lastName, pigFirst, pigLast;

            //get names from user
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine().ToLower();

            //convert names to Pig Latin using method created below
            pigFirst = PigTranslator(firstName);
            pigLast = PigTranslator(lastName);

            Console.WriteLine("Your name translated to Pig Latin is: " + pigFirst + " " + pigLast);

        }

        //method for translating English name to Pig Latin including proper capitalization
        static string PigTranslator(string str)
        {
            str = str.ToLower();
            string pig, temp;
            temp = str[0].ToString();
            pig = str.Substring(1) + temp + "ay";
            temp = pig[0].ToString().ToUpper();
            pig = temp + pig.Substring(1);
            return pig;
        }
    }
}
