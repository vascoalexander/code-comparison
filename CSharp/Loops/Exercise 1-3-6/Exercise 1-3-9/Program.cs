// Exercise 1-3-9
namespace Exercise_1_3_9
{
    internal class Program
    {
        static void Main()
        {

            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == col)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine("");
            }
        }
    }
}
