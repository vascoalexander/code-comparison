Console.Write("Enter your weight: ");
double weight = Convert.ToDouble(Console.ReadLine());
weight *= 2;
string isElegible;

if (weight > 235 && 265 > weight)
{
    isElegible = "";
}
else
{
    isElegible = "not ";
}
string message = $"You are {isElegible}elegible to enter the competition";
Console.WriteLine(message);