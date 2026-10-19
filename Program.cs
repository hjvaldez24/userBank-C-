using System;
using Microsoft.VisualBasic;

namespace userBalance
{
    class Program
    {
        /// <summary>
        /// This code was created while studying C#, so I decided to create the banking system and will continue the study in C#. 
        /// The banking system was not complete, and I just created this to test myself if I have applied the lesson in Coursera  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome for the OnlyBank");
            Console.WriteLine("=======================================");
            Console.WriteLine("         USER ACCOUNT    ");
             Console.WriteLine("=======================================");

            //this is for the user account so you need to input the name of the user here.
            Console.WriteLine("Enter your NAme:");
            string userNameInput = Console.ReadLine();

            //User starting balance
            decimal balance = 1500.9m;


            bool continueRunning = true;

            while (continueRunning) //this loop keeps the program running as long the user want to continue the transaction of the bank
            {
                Console.WriteLine("     User Status Balance     ");
                Console.WriteLine($"Username: {userNameInput}");
                Console.WriteLine($"Balance: ${balance:F2}");

                //here i create an deposite so the user can deposite
                Console.WriteLine("Enter deposite:");
                string input1 = Console.ReadLine();;
                
                //here i make a statement for the parsing to prevent craching if the letters are entered
                if (decimal.TryParse(input1, out decimal amount1) && amount1 >= 0)
                {
                    balance += amount1; // this is to update the actual balance of the user
                    Console.WriteLine($"User total balance: ${balance:F2}");                   
                }
                else
                {
                    Console.WriteLine("Invalid deposite amount. Try again.");
                    continue; // this code  line was make to continue the program if the user try to enter a letter and return to the deposit section
                }

                    //here is the selection transaction for the bank if the user want to continue
                    Console.WriteLine("Do you want to continue? (y/n):");
                    //ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                    string confirmationInput = Console.ReadLine()?.Trim().ToLower();

                    //here is the statement for the Y or N confirmation of the transaction of the bank
                    if (confirmationInput == "y" | confirmationInput == "yes")
                    {
                        Console.WriteLine("You select: Yes");
                    } 
                    else if (confirmationInput == "n" | confirmationInput == "no")
                    {
                        Console.WriteLine("You select: No");
                        Environment.Exit(0); // this part is to exit the terminal or break the loop
                    }
                    else
                    {
                        Console.WriteLine("\n Invalid Key");
                    }
            }
        }
    }
}