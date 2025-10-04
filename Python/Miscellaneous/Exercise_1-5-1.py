# Exercise 1-5-1

# with Modulo
number = float(input('Enter a number: '))
integer_part = int(number)
decimal_part = int(((number - integer_part)*100) % 100)
print(f"Abbreviated number: {integer_part}.{decimal_part}")

# lazy
number = float(input('Enter a number: '))
print(f"Rounded number: {number:.2f}")