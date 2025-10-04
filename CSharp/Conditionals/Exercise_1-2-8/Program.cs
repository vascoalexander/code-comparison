// Exercise 1-2-8
Console.Write("Enter the amount to be converted: ");
double money = Convert.ToDouble(Console.ReadLine());
Console.Write("Convert to? (e for euro or d for dm): ");
string convertTo = Console.ReadLine();
string message;
if (convertTo == "e" || convertTo == "E")
{
    message = Convert.ToString($"{money} Dm are {money / 1.95583} in Euro.");
}
else
{
    message = Convert.ToString($"{money} Euro are {(money * 1.95583):N2} in DM.");
};
Console.WriteLine(message);
