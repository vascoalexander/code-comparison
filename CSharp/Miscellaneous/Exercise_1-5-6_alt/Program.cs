// Exercise 1-5-6_alt
// An efficienter alternative

class Program
{
    static bool CheckIfPrimeNumber(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int sqrt = (int)Math.Sqrt(number);
        for (int i = 3; i <= sqrt; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a positive number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number < 2)
            {
                Console.WriteLine("Invalid Input. The number must be higher than 1.");
            }
            else
            {
                if (CheckIfPrimeNumber(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

