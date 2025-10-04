// Exercise 1-4-2
class Programm
{
    static bool ElementInList(List<int> lst, int element)
    {
        if (lst.Contains(element))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.WriteLine(ElementInList([1,2,3,4,5,6],2));
        Console.WriteLine(ElementInList([3,6,9,7,11],-1));
        
    }
}

