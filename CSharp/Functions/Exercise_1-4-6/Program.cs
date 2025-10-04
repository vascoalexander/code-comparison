// Exercise 1-4-6
class Program
{
    static int Minimum(List<int> lst)
    {
        int min = lst[0];
        foreach (int i in lst)
        {
            if (i < min)
            {
                min = i;
            }
        }
        return min;
    }
    static void Main()
    {
        Console.WriteLine(Minimum(new List<int> { -9, 2, 4, 1, 8 }));
        Console.WriteLine(Minimum(new List<int> { -3, 1, 7, 6, -4, 3 }));
    }
}
