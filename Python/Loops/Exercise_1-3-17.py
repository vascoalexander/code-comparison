# Exercise 1-3-17

# with modulo and integer division
number = int(input("Enter number: "))
cross_sum = 0
while number > 0:
    cross_sum += number % 10
    number = number//10
print(cross_sum)

# with string method
number = input("Enter number: ")
cross_sum = 0
for char in number:
    cross_sum += int(char)
print(cross_sum)

# with list and sum function
number = input("Enter number: ")
lst = []
for num in number:
    lst.append(int(num))
print(sum(lst))