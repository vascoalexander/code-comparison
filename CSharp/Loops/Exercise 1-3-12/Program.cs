using System;

int coins = 10;
bool active = true;

Console.WriteLine($"You have {coins} to play!");

while (active)
{
    Console.Write("Press return to start game or enter 'quit' to exit: ");
    string quit = Console.ReadLine().ToLower();

    Random rnd = new();
    int first = rnd.Next(0, 9);
    int second = rnd.Next(0, 9);
    int third = rnd.Next(0, 9);

    var result = $"{first} {second} {third}";

    if (quit == "quit")
    {
        active = false;
    }
    else
    {   if ((first == second) && (second == third))
        {
            coins += 10;
            Console.WriteLine($"{result} | You won 10 Coins. Coins left: {coins}");

        }
        else if ((first == second) || (second == third) || (third == first))
        {
            coins += 3;
            Console.WriteLine($"{result} | You won 3 Coins. Coins left: {coins}");
        }
 
        else
        {
            coins -= 1;
            Console.WriteLine($"{result} | You lost! Coins left: {coins}");
        }
        if (coins == 0)
        {
            active = false;
        }
    }
}
