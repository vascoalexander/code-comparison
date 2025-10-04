# Exercise 1-3-20
from random import randint

print("I am thinking of a number between 1 and 10.")
print("You have 3 attempts to guess the number.")

random_number = randint(1,10)
active = True
attempts = 0

while active:
    number = int(input("Enter a number between 1 and 10: "))
    if number == random_number:
        print("You won")
        active = False
    else:
        attempts += 1
    
    if attempts == 3:
        print("You lose")
        print(f"The right number was {random_number}")
        active = False
    
