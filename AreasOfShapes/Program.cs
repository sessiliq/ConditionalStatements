namespace AreasOfShapes
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double sideA = double.Parse(Console.ReadLine());
            double area = 0;

            if (shape == "square")
            {
                area = sideA * sideA;
            }
            else if (shape == "triangle")
            {
                double heigth = double.Parse(Console.ReadLine());
                area = sideA * heigth / 2;
            }
            else if (shape == "circle")
            {
                area = Math.PI * sideA * sideA;
            }
            else if (shape == "rectangle")
            {
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }

            Console.WriteLine("{0:f3}", area);
        }
    }
}
