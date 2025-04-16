using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message to the user.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight and read the input.
            Console.WriteLine("Please enter the package weight:");
            // Convert the input string to a double data type.
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package weight exceeds the maximum limit of 50.
            if (weight > 50)
            {
                // If the weight is too high, display an error message and terminate the program.
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Wait for user input before closing the console window.
                Console.ReadKey();
                // Exit the application.
                return;
            }

            // Prompt the user for the package width and read the input.
            Console.WriteLine("Please enter the package width:");
            // Convert the input string to a double data type.
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package height and read the input.
            Console.WriteLine("Please enter the package height:");
            // Convert the input string to a double data type.
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package length and read the input.
            Console.WriteLine("Please enter the package length:");
            // Convert the input string to a double data type.
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate the sum of the package dimensions.
            double dimensionsTotal = width + height + length;

            // Check if the total dimensions exceed the maximum limit of 50.
            if (dimensionsTotal > 50)
            {
                // If the dimensions are too large, display an error message and terminate the program.
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Wait for user input before closing the console window.
                Console.ReadKey();
                // Exit the application.
                return;
            }

            // Calculate the shipping quote using the formula: (width * height * length * weight) / 100.
            double quote = (width * height * length * weight) / 100.0;

            // Display the calculated shipping quote, formatted as currency (e.g., $123.45).
            // The "C" format specifier automatically uses the current culture's currency settings.
            Console.WriteLine($"Your estimated total for shipping this package is: {quote:C}");

            // Display a thank you message to the user.
            Console.WriteLine("Thank you!");

            // Wait for user input before closing the console window, allowing the user to see the output.
            Console.ReadKey();
        }
    }
}
