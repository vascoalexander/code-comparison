# Exercise 1-2-7
weight = float(input('Enter the weight of your parcel(in kg): '))
if weight <= 10.0:
    shipmentCost = 3.0
else:
    shipmentCost = ((weight - 10) // 1 + 1) * 0.25 + 3.0   
print(f"Shipment Cost: {shipmentCost}")

# alternative using ceil
from math import ceil
weight = float(input('Enter the weight of your parcel(in kg): '))- 10
print(f"Shipment Cost: {ceil(weight)*0.25 + 3}")

