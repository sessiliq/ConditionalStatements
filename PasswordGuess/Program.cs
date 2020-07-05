namespace PasswordGuess
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string truePassword = "s3cr3t!P@ssw0rd";
            if (password == truePassword)
            {
                Console.WriteLine("Welcome");
            }
            else 
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
