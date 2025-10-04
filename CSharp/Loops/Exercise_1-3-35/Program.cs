// Exercise 1-3-35
int counter = 0;
for (int i = 0; i < 1000; i++)
{
    string number = i.ToString();
    if (!number.Contains("7"))
    {
        Console.Write($"{number,4}");
        counter++;
        if (counter == 10)
        {
            Console.WriteLine();
            counter = 0;
        }
    }
}
