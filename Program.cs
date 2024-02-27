namespace factorialdowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            int i = 1;

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers");
            }
            else if (number == 0)
            {
                Console.WriteLine("Factorial of 0 is 1");
            }
            else
            {
                do
                {
                    factorial *= i;
                    i++;
                } while (i <= number);

                Console.WriteLine($"Factorial of {number} is {factorial}.");
            }
        }
    }
}