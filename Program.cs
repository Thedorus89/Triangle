using System;

class Program
{
    static void Main()
    {
        int height = 10; // Height of the triangle

        // Loop through each row of the triangle
        for (int i = 1; i <= height; i++)
        {
            // Print spaces before the asterisks
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            // Print asterisks for the current row
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Move to the next line
        }

        Console.ReadLine(); // Keep the console window open
    }
}
