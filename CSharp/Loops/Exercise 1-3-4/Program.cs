Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = n; i > 0; i--)
{
    sum += i;
}
Console.WriteLine(sum);
