// Exercise 1-5-1

// with modulo
Console.Write("Enter a number: ");
decimal number1 = Convert.ToDecimal(Console.ReadLine());
int integerPart = (int)number1;
int decimalPart = (int)((number1 - integerPart) * 100) % 100;
Console.WriteLine($"Abbreviated number: {integerPart}.{decimalPart}");

// lazy
Console.Write("Enter a number: ");
decimal number2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Rounded number: {number2:F2}");
