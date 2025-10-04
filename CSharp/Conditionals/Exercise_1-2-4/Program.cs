int currentMax = 0;
for (int i = 0; i< 7; i++)
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > currentMax)
    {
    currentMax = number;
    }
}
Console.WriteLine($"The hightest number you entered was: {currentMax}");