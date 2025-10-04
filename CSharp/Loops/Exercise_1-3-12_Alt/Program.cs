// Exercise 1-3-12 Alternative
class Program
{
    static int StartGame(int coins)
    {
        Random rnd = new();
        int first = rnd.Next(0, 9);
        int second = rnd.Next(0, 9);
        int third = rnd.Next(0, 9);

        Console.WriteLine($"{first} {second} {third} | Coins left: {coins}");
        return coins += GameResult(first, second, third);

    }
    static int GameResult(int first, int second, int third)
    {

        if ((first == second) && (second == third))
        {
            return 10;
        }
        else if ((first == second) || (first == third) || (second == third))
        {
            return 3;
        }
        else
        {
            return -1;
        }
    }

    static void Main()
    {
        int coins = 10;

        while (true)
        {
            Console.WriteLine($"You have {coins} to play!");
            Console.Write("Press return to start game or enter 'quit' to exit: ");
            string play = Console.ReadLine().ToLower();

            if (play == "quit" || coins == 0)
            {
                Console.WriteLine($"You won {coins}! Good bye!");
                break;
            }
            else
            {
                coins = StartGame(coins);
            }
        }

    }
}
