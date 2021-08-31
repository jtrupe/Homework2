/// Homework 2 Lab 1		
///
/// @author: Julian Trupe
/// Date:  August 30, 2021
///
/// Problem Statement: Ask the user to enter three numbers, 
/// then perform mathematical operation and output to the screen
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for three integers
/// 3) Calculate the sum and product of the three integers
/// 4) Divide the sum by the product to calculate the quotient
/// 5) Print the product and qutient of the integers to the screen, with appropriate messages
/// 

using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen, prompting user input
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will do somme math today.");
            Console.WriteLine("Please enter three integers, each on their own line");

            // declare all variables
            int n1, n2, n3, product, sum, quotient;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these three numbers
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;

            //calculate the quotient
            quotient = sum / product;

            // print the sum, product and quotient to the screen along with appropriate messages
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);
            Console.WriteLine("The product of those three numbers is");
            Console.WriteLine(product);
            Console.WriteLine("The quotient of the sum and product is");
            Console.WriteLine(quotient);

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
