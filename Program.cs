using System;

namespace userBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome for the OnlyBank");
            Console.WriteLine("=======================================");
            Console.WriteLine("         USER ACCOUNT    ");
             Console.WriteLine("=======================================");

            //this is for the user account so you need to input the name of the user here.
            Console.WriteLine("Enter your NAme:");
            string userNameInput = Console.ReadLine();

            //User balance status
            decimal balance = 1500.9m;

            //
            Console.WriteLine("     User Status Balance     ");
            Console.WriteLine($"Username: {userNameInput}");
            Console.WriteLine($"Balance: ${balance:F2}");

            //here i create an deposite so the user can deposite
            Console.WriteLine("Enter deposite:");
            string input1 = Console.ReadLine();
            decimal amount1 = Convert.ToDecimal(input1);

            //this is the total balance of the user and the deposite of the user
            //and this is the computation of ther current balance and deposite
            decimal totalBalance = balance + amount1;

            //this line code will display in the screen of the user
            Console.WriteLine($"User total balance: ${totalBalance}");

            
        }
    }
}