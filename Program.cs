namespace Task_4;

class Program
{
    static void Main(string[] args)
     {
            // Declare and initialize an integer array
            int[] numbers = { 2, 4, 6, 8, 10 };

            // Calculate the sum of all elements in the array
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Print the sum to the console
            Console.WriteLine("Sum of all elements: " + sum);

            // Use a foreach loop to iterate over the array and print each element
            Console.WriteLine("Array elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Keep the console window open
            Console.ReadLine();
        }
}
