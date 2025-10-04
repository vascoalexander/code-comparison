// Exercise 1-2-13
Console.Write("Enter the capacity of the fuel Tank: ");
double tankCapacity = Convert.ToDouble(Console.ReadLine());
Console.Write("How much fuel is consumed for 100km?: ");
double fuelComsumption = Convert.ToDouble(Console.ReadLine());
Console.Write("How much fuel is left (in %)");
double fuelLeft = Convert.ToDouble(Console.ReadLine());

double rangeLeft = tankCapacity * (fuelLeft / 100) / (fuelComsumption / 100);

Console.WriteLine($"You have fuel left for {rangeLeft}");

if (rangeLeft < 200)
{
    Console.WriteLine("Refuel");
}
else
{
    Console.WriteLine("Continue Driving");
}