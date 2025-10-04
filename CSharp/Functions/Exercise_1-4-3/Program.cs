// Exercise 1-4-3
class Program
{
    static int SumOfElements(List<int> lst)
    {
        int sum = 0;
        foreach (int i in lst)
        {
            sum += i;
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine(SumOfElements(new List<int> { 1, 2, 3, 4, 5, 6 }));
        Console.WriteLine(SumOfElements(new List<int> { 3, 6, 9, 7, 11 }));
    }

}
