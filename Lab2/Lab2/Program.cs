using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal userLength, userWidth;
            string lowKeepGoing;
            do
            {
                Console.WriteLine("Enter Length: ");
                bool lengthSuccess = Decimal.TryParse(Console.ReadLine(), out userLength);

                Console.WriteLine("Enter Width: ");
                bool widthSuccess = Decimal.TryParse(Console.ReadLine(), out userWidth);

                if (lengthSuccess == true && widthSuccess == true)
                {
                    decimal roomArea = userLength * userWidth;
                    decimal roomPerimeter = 2 * (userLength + userWidth);
                    Console.WriteLine($"Area: {roomArea}");
                    Console.WriteLine($"Perimeter: {roomPerimeter}");
                    Console.WriteLine();
                }

                Console.WriteLine("Continue? (y/n)");
                string keepGoing = Console.ReadLine();
                Console.WriteLine();
                lowKeepGoing = keepGoing.ToLower();



            } while (lowKeepGoing == "y");

            Console.WriteLine();
            Console.WriteLine("Program ended.");
            Console.ReadKey();




        }
    }
}
