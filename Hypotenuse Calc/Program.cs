using System;

// Finding the hypotenuse of a right triangle
// Formula is c = a^2 + b^2
// Get input from user for two sides a and b and calculate for c

namespace HelloWorld
{
    class HypotenuseCalc
    {
        static void Main()
        {
            // Declaring variables for converting user input to integers for calculating
            string strA, strB;
            double a, b, c;

            Console.WriteLine("This app will calculate a hypotenuse of a right triangle for you. Please enter the height of the triangle: ");
            strA = Console.ReadLine();
            a = Convert.ToDouble(strA);

            Console.WriteLine("Please enter the width of the triangle: ");
            strB = Console.ReadLine();
            b = Convert.ToDouble(strB);

            // Calculation for hypotenuse
            c = Math.Sqrt(a * a + b * b);

            // Output to user
            Console.WriteLine("The hypotenuse of your right triangle is " + c);
        }
    }
}