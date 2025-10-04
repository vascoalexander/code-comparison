# Exercise 1-2-11
year = int(input('Enter the a Year: '))
if year % 400 == 0:
    leapyear = ""
elif year % 4 == 0 and year % 100 != 0:
    leapyear = ""
else:
    leapyear = " not"
print(f'{year} is{leapyear} a Leap Year.')