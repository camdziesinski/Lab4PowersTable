using System;

namespace Lab4PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Power Table Generator.\nWe will square and cube from 1 assending to the number you have choosen");

            string userGo = "y";
            while (userGo == "y")
            {
                int Square, Cube, Number;
                Console.WriteLine("Please enter a number");

                string userInput = Console.ReadLine();


                bool isNumber = int.TryParse(userInput, out Number);

                while (isNumber == false)

                {

                    Console.WriteLine("Please enter a whole number.");

                    userInput = Console.ReadLine();

                    isNumber = int.TryParse(userInput, out Number);

                }
                Console.WriteLine("\t=========================================");
                Console.WriteLine("\tNumber\t|\tSquare\t|\tCube");
                Console.WriteLine("\t=========================================");

                for (int i = 1; i <= Number; i++)
                {
                    Square = i * i;
                    Cube = Square * i;
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}", i, Square, Cube);
                }
                
                userGo = "";
                while (userGo != "y" && userGo != "n")

                {
                    Console.WriteLine($"Would you like to enter another number? (y/n)");
                    userGo = Console.ReadLine().ToLower();
                }

                if (userGo == "n")
                    {
                        Console.WriteLine($"Goodbye.");

                    }
            }
            
        }
    }
}