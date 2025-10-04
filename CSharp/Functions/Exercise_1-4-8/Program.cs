// Exercise 1-4-8
class Program
{
    static int Length(List<int> lst)
    {
        int counter = 0;
        foreach (int item in lst)
        {
            counter++;
        }
        return counter;
    }
    static void Main()
    {
        Console.WriteLine(Length(new List<int> { 2, 7, 23, 44, 1, 0 }));
        Console.WriteLine(Length(new List<int> {}));
    }
}
