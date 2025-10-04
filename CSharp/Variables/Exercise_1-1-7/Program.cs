// Exercise 1-1-7
double x = 22;
double y = 7;
double number = x / y;
Console.WriteLine(number);

int firstDigit = (int)(number * 10 % 10);
int secondDigit = (int)(number * 100 % 10);
int thirdDigit = (int)(number * 1000 % 10);
number = Convert.ToInt32(number);

Console.WriteLine($"{number}.{firstDigit}{secondDigit}{thirdDigit}");
