# Exercise 1-3-7
iterations = int(input("How much numbers to add: "))
sum = 0
for i in range(iterations):
    number = int(input("Enter number: "))
    sum += number
print("The sum is: " + str(sum))