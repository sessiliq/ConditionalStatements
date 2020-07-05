namespace ToyShop
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double earn = numberOfPuzzles * 2.60 + numberOfDolls * 3 + numberOfBears * 4.10 + numberOfMinions * 8.20 + numberOfTrucks * 2;
            int numberOfToys = numberOfPuzzles + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;

            if (numberOfToys >= 50)
            {
                earn = earn * 0.75;
            }

            double rent = earn * 0.1;
            double totalEarn = earn - rent;

            if (totalEarn >= trip)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", totalEarn - trip);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", trip - totalEarn);
            }
        }
    }
}
