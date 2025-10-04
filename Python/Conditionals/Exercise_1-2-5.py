# Exercise 1-2-5
age = int(input('Enter your Age: '))
if age >= 18:
    print('The user is of legal age.')
else:
    print('The user is a minor')

# shorter alternative
age = int(input('Enter your Age: '))
adult = 'of legal Age.' if age >= 18 else 'a minor.'
print(f"The user is {adult}")