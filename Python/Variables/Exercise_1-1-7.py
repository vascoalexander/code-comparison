x = 22
y = 7
number = x/y
print(number)

# get first number after comma
firstDigit = int(number * 10 % 10)
secondDigit = int(number * 100 % 10)
thirdDigit = int(number * 1000 % 10)
number = int(number)
print(f"{number}.{firstDigit}{secondDigit}{thirdDigit}")

# alternative shorter
x = 22
y = 7
number = x/y
digits = int(number * 1000 % 1000)
number = int(number)
print(f"{number}.{digits}")
