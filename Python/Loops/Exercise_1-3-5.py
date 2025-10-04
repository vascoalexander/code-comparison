# Exercise 1-3-5
number = int(input("Enter a number: "))
product = 1
for i in range(1, number + 1, 2):
    product *= i
print(product)