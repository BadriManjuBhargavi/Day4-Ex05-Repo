using System;

class Program
{
    static void Main()
    {
        string validUsername = "admin";
        string validPassword = "password";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == validUsername && password == validPassword)
            {
                Console.WriteLine("Login successful.");
                break;
            }
            else if (username == validUsername)
            {
                Console.WriteLine("Invalid password.");
            }
            else
            {
                Console.WriteLine("Invalid username.");
            }

            attempts++;
        }

        if (attempts == 3)
        {
            Console.WriteLine("Login failed.");
        }
    }
}
