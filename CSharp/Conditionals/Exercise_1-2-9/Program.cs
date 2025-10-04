// Exercise 1-2-9
Console.Write("Enter the weight of your parcel (in kg): ");
double weight = Convert.ToDouble(Console.ReadLine());
double shipmentFee = 0.25;
int extraWeight = (int)(weight - 10);

if (weight <= 10.0)
{
    shipmentFee = 0.0;
}
else if (weight > 20.0)
{
    shipmentFee = 0.5;
}

if ((weight - extraWeight - 10) != 0)
{
    extraWeight += 1;
}

double shipmentCost = extraWeight * shipmentFee + 3.0;
Console.WriteLine($"Shipment Cost: {shipmentCost}");

