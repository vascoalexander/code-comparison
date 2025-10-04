// Exercise 1-3-20
class Program
{

    static void Main()
    {
        Console.WriteLine("I am thinking of a number between 1 and 10");
        Console.WriteLine("You have 3 attempts to guess the number");

        Random random = new Random();
        bool active = true;
        int attempts = 0;

        while (active)
        {
            int next_rnd = random.Next(1,10);
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == next_rnd)
            {
                Console.Write("You won");
                active = false;
            }
            else
            {
                attempts++;
            }

            if (attempts == 3)
            {
                Console.WriteLine("You lose");
                Console.WriteLine($"The right number was {next_rnd}");
                active = false;
            }
        }

    }

}