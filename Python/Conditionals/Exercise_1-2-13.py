# Exercise 1-2-13
tank_capacity = int(input("Enter the capacity of the fuel Tank: "))
fuel_comsumption = int(input("How much fuel is consumed for 100km?: "))
fuel_left = int(input("How much fuel is left (in %): "))

rangeLeft = (tank_capacity * (fuel_left / 100)) / (fuel_comsumption / 100)

print(f"You have fuel left for {rangeLeft:.1f}")

if rangeLeft < 200:
    print("Refuel")
else:
    print("Continue driving")
