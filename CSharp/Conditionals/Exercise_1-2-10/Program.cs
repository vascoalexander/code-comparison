// Exercise 1-2-10
Console.Write("Enter your birthyear(YY): ");
int birthyear = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the current Year(YY): ");
int currentYear = Convert.ToInt32(Console.ReadLine());
int age;

if  (birthyear > currentYear)
{
    age = (currentYear + 100) - birthyear;
}
else
{
    age = currentYear - birthyear;
};
Console.WriteLine($"Your age is {age}.");