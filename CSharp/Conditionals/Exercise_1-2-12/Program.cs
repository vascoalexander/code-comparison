// Exercise 1-2-12
Console.Write("How much portions to heat?: ");
int portions = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the heating time (in sec): ");
int heatingTime = Convert.ToInt32(Console.ReadLine());
double heatingTimeMod = 1.0;

if (portions == 2)
{
    heatingTimeMod = 1.5;
}
else if (portions == 3)
{
    heatingTimeMod = 2.0;
}
else if (portions > 3)
{
    Console.WriteLine("Heating more than 3 portions is not recommended");
}

int m = (int)(heatingTime *  heatingTimeMod) / 60;
int s = (int)(heatingTime * heatingTimeMod) % 60;

Console.WriteLine($"Time to heat: {m} min {s} sec");
