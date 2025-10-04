// Exercise 1-4-1
class Programm
{
    static int MathTest(int a, int b, int x)
    {
        int result = a * (x * x * x) + 2 * a * (x * x) + b;
        return result;
    }
    static void Main()
    {
        Console.WriteLine(MathTest(3, 0, 1));
        Console.WriteLine(MathTest(0, 2, 0));
    }
}

