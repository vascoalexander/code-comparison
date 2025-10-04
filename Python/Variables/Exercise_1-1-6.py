# Exercise 1-1-6
firstNumber = int(input('Enter the first number: '))
secondNumber = int(input('Enter the second number: '))
# floating number division
print(firstNumber/secondNumber)
# integer division
print(firstNumber//secondNumber)

# alternative covering 0 as userinput
firstNumber = int(input('Enter the first number: '))
secondNumber = 0
while secondNumber == 0:
    secondNumber = int(input('Enter the second number: '))
    if secondNumber == 0:
        print('Division by Zero is not allowed. Enter another number!')
print(firstNumber/secondNumber)