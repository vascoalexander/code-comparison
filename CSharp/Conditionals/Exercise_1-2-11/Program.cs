Console.Write("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());
string isLeapYear;
if (year % 400 == 0)
{
    isLeapYear = "";
}
else if (year % 4 == 0 && year % 100 != 0)
{
    isLeapYear = "";
}
else
{
    isLeapYear = " not";
}
Console.WriteLine($"{year} is{isLeapYear} a Leap Year");
