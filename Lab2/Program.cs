/// Homework 2 Lab 2		
///
/// @author: Julian Trupe
/// Date:  August 30, 2021
///
/// Problem Statement: Calculate the number of candy bars and gumballs the user 
/// may redeem their coupons for, user prefers candy bars
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for the number of coupons they won ( = tix)
/// 3) Calculate how many candy bars by dividing coupons by 10
/// 4) Calculate the modulus of tix and 10, store this remainder
/// 5) Calculate how many gumballs by dividing remainder above by 3
/// 6) Print the resulting candybars and gumballs to the screen with a message
/// 

using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //print initial message and prompt
            Console.WriteLine("Uh Oh! Game Over!");
            Console.WriteLine("How many coupons did you win today?");

            // declare all variables
            int tix, candyBars, gumballs, remainder;
            int candyCost = 10;
            int gumCost = 3;

            string userInput;
            userInput = Console.ReadLine();
            tix = Int32.Parse(userInput);

            // calculate the number of candybars and gumballs
            candyBars = tix / candyCost;
            remainder = tix % candyCost;
            gumballs = remainder / gumCost;

            // print the amount of candybars and gummballs to the screen along with appropriate messages
            Console.WriteLine("You have enough coupons for " + candyBars + " candy bars and " + gumballs + " gumballs.");

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
