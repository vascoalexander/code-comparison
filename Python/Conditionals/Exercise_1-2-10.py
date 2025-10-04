# Exercise 1-2-10
birthyear = int(input('Enter your birthyear(YY): '))
current_year = int(input('Enter the current Year(YY): '))
if birthyear > current_year:
    age = (current_year + 100) - birthyear
else:
    age = current_year - birthyear
print(f'Your age is {age}.')