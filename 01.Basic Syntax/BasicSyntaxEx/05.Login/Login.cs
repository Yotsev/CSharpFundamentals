using System;


namespace _05.Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            int count = 1;

            string pass = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i];
            }
            // string pass = string.Join("", username.Reverse())
            while (pass != password)
            {
                if (count >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                count++;
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
