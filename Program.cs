using System;
using System.ComponentModel.Design;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password");
            string password = Console.ReadLine();

            {
                bool lowercase = true;
                bool alphanumeric = true;
                // Check each conditions 
                foreach (char x in password)
                {
                    if (char.IsUpper(x))
                    {
                        lowercase = false;
                    }
                    else if (!char.IsLetterOrDigit(x))
                    {
                        alphanumeric = false;
                    }
                }
                // Check if password meets all conditions
                bool validPassword = lowercase && alphanumeric;

                if (validPassword)
                {
                    Console.WriteLine("This password is valid");
                }
                else
                {
                    Console.WriteLine("This password is invalid");
                }
            }
        }
    }
}

