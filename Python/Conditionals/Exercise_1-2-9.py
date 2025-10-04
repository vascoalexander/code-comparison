# Exercise 1-2-9
weight = float(input('Enter the weight of your parcel(in kg): '))
shipment_fee = 0.25
extra_weight = (weight - 10) // 1

if weight <= 10.0:
    shipment_fee = 0.0
elif weight > 20.0:
    shipment_fee = 0.5

if weight - extra_weight - 10 != 0:
    extra_weight += 1

shipmentCost = extra_weight * shipment_fee + 3.0   
print(f"Shipment Cost: {shipmentCost}")