// Exercise 1-2-5
Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("The user is of legal age.");
}
else
{
    Console.WriteLine("The user is a minor.");
}

// shorter alternative
Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());
string isAdult = (age >= 18) ? "of legal age." : "a minor";
Console.WriteLine($"The user is {isAdult}");