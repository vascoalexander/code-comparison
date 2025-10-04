// Exercise 1-5-6
class Program
{
    static bool CheckIfPrimenumber(int number)
    {
        bool prime = true;
        for (int i = 2; i < (number + 1); i++)
        {
            if (number % i == 0)
            {
                prime = false;
                break;
            }
        }
        return prime;
        
    }
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 2)
        {
            Console.WriteLine("Invalid Input. The number must be higher than 1.");
        }
        else
        {
            if (CheckIfPrimenumber(number) || (number == 2))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }
}