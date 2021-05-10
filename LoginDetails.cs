using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class LoginDetails
    {
        void UserAndPassword()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the user name:");
                string Username = Console.ReadLine();
                Console.WriteLine("Enter the password:");
                string password = Console.ReadLine();
                if (Username == "Admin" && password == "admin")
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                { 
                    Console.WriteLine("Invalid username or password");
                    count += 1;
                }
            }
            if (count >= 3)
            {
                Console.WriteLine("Account closed");
                Console.WriteLine("Sorry you have already tried 3 times");
            }
            else
            {
                Console.WriteLine("Loged in successfully");
            }
        }
        static void Main(string[] args)
        {
            LoginDetails loginDetails = new LoginDetails();
            loginDetails.UserAndPassword();
            Console.ReadKey();
        }
    }
}
