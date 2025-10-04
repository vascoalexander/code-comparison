// Exercise 1-3-7
Console.Write("How much numbers to add: ");
int iterations = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < iterations; i++)
{
    Console.Write("Enter number: ");
    int nextNumber = Convert.ToInt32(Console.ReadLine());
    sum += nextNumber;
}
Console.WriteLine("The sum is: " +  sum);