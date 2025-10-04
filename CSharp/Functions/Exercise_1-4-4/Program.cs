// Exercise 1-4-4
class Program
{
    static List<int> RemoveDuplicates(List<int> lst)
    {
        HashSet<int> set = new HashSet<int>(lst);
        List<int> uniquelist = set.ToList();
        uniquelist.Sort();
        return uniquelist;
    }
    static void Main()
    {
        List<int> sortedUniqueList1 = RemoveDuplicates(new List<int> { 0, 3, 5, 7, 3, 5, 1, -1 });
        foreach (int i in sortedUniqueList1)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        List<int> sortedUniqueList2 = RemoveDuplicates(new List<int> { 0, 5, 9, 10, 3, 2, 1, -3 });
        foreach (int i in sortedUniqueList2)
        {
            Console.Write(i + " ");
        }
    }
}
