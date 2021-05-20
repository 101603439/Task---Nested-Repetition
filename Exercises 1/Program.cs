using System;

namespace Exercises_1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("What is your name");
            string YourName =  Console.ReadLine();

            int counter = 0;
            int counter2 = 1;

            while (counter < 5)
            {
                counter2 = counter;

                while (counter2 < 10)
                {
                    System.Console.WriteLine(YourName);
                    counter2 = counter2 +1; 
                }
                Console.WriteLine();
                counter = counter +1;
            }
            System.Console.WriteLine("Goodbye" + YourName);
        }
    }
}
