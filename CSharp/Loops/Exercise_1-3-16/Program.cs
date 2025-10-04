int counter = 0;
while (counter < 7)
{
    Console.Write(" " + counter);
    counter++;
}

Console.WriteLine();

counter = 0;
List<int> lst = new List<int> { 2, 5, 3, 1, 4 };
while (counter < lst.Count)
{
    Console.Write(" " + lst[counter]);
    counter++;
}



