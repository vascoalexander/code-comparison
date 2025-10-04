# Exercise 1-5-5
from random import randint

lottory_numbers = []
while len(lottory_numbers) < 7:
    next_number = randint(1,50)
    if next_number not in lottory_numbers:
        lottory_numbers.append(next_number)

print(lottory_numbers)