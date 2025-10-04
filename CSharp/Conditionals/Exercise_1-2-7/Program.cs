// Exercise 1-2-7
// To get correct results the input has to be formated with a comma and not with a dot!
Console.Write("Enter the weight of your parcel: ");
double weight = Convert.ToDouble(Console.ReadLine());
double shipmentCost;
if (weight <= 10.0)
{
    shipmentCost = 3.0;
}
else
{
    int extraWeight = (int)(weight - 10);
    double remainingWeight = (weight - 10) - extraWeight;
    shipmentCost = 3.0 + extraWeight * 0.25;

    if (remainingWeight > 0)
    {
        shipmentCost += 0.25;
    }
}
Console.WriteLine($"Shipment Cost: {shipmentCost}");