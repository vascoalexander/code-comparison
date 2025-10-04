// Exercise 1-4-5
class Program
{
    static int Maximum(List<int> lst)
    {
        int max = lst[0];
        foreach (int i in lst)
        {
            if (i > max)
            {
                max = i;
            }
        }
        return max;
    }
    static void Main()
    {
        Console.WriteLine(Maximum(new List<int> { -9, 2, 4, 1, 8 }));
        Console.WriteLine(Maximum(new List<int> { -3, 1, 7, 6, 2, 3 }));
    }
}

