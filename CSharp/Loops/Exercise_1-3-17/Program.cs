// Exercise 1-3-17

// with modulo and integer division
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int cross_sum = 0;

while (number > 0)
{
    cross_sum += number % 10;
    number = number / 10;
}
Console.WriteLine(cross_sum);

// string method
Console.Write("Enter number: ");
string numbers = Console.ReadLine();
cross_sum = 0;
foreach (var item in numbers)
{
    cross_sum += item - '0';
}
Console.WriteLine(cross_sum);

// with list
Console.Write("Enter number: ");
string num = Console.ReadLine();
List<int> lst = new List<int>();
foreach (var item in num)
{
    int next_number = item - '0';
    lst.Add(next_number);
}
Console.WriteLine(lst.Sum());


