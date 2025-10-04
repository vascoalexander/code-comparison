// Exercise 1-2-6
Console.Write("How much money is in your current Account?: ");
double currentAccount = Convert.ToDouble(Console.ReadLine());
Console.Write("How much money is in your savings Account?: ");
double savingsAccount = Convert.ToDouble(Console.ReadLine());
if (currentAccount > 1000 || savingsAccount > 1500)
{
    Console.WriteLine($"The fee is 0.15 euro.");
}
else
{
    Console.WriteLine($"No fee charged");
}

// shorter alternative
Console.Write("How much money is in your current Account?: ");
currentAccount = Convert.ToDouble(Console.ReadLine());
Console.Write("How much money is in your savings Account?: ");
savingsAccount = Convert.ToDouble(Console.ReadLine());
double fee = (currentAccount > 1000 || savingsAccount > 1500) ? 0.15 : 0.0;
Console.WriteLine($"The fee is {fee}.");
