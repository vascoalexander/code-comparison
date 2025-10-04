# Exercise 1-2-4
current_max = 0
for i in range(0,7):
    number = int(input('Enter a number: '))
    if number > current_max:
        current_max = number
print(current_max)