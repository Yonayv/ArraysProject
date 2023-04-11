using System;

namespace ArraysProjectYF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input a whole number to be stored in array.
            Console.WriteLine("Enter a whole number for the array size.");

            // Converts int arraySize to print console
            int arraySize = Convert.ToInt32(Console.ReadLine());

            // Creates an int array of that size.
            int[] numbers = new int[arraySize];

            // int sum set to 0
            int sum = 0;

            // 1st int i set to 0, element will go until arraySize.
            for (int i = 0; i < arraySize; i++)
            {
                // Asks user to input a whole number to be stored in array.
                Console.WriteLine("Enter a whole number to add to the array.");

                // Assigns each int i a new value until end of array.
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                // Adds every int i in the array and adds to the sum.
                sum += numbers[i];
            }

            // Interpolates the sum in the console writeline.
            Console.WriteLine($"The sum of the array is {sum}");

            // Sorts the numbers of the array.
            Array.Sort(numbers);

            // Array header
            Console.WriteLine("Array");

            // Loops through the array and print all to console.
            foreach(int number in numbers)
            {
                // For each int number in the array prints out to the console. 
                Console.WriteLine(number);
            }
        }
        
        
    
    }
}
