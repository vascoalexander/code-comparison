Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = n; i > 0; i--)
{
    if (i % 2 != 0)
    {
        sum *= i;
    }   
}
Console.WriteLine(sum);
