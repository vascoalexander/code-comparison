// Exercise 1-4-7
// in difference to pythons list-slicing GetRange does not use an end index. Instead we count up from a start index
class Program
{
    static int SliceSum(List<int> lst, int start, int count)
    {
        List<int> slice = lst.GetRange(start, count);
        int sum = 0;
        foreach (int i in slice)
        {
            sum += i;
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine(SliceSum(new List<int> { 4, 10, 12, 16, 18 }, 2, 3));
        Console.WriteLine(SliceSum(new List<int> { 2, 4, 6, 8, 10, 12 }, 0, 2));
    }
}
