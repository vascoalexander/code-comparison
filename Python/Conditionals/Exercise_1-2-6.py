# Exercise 1-2-6
current_account = float(input('How much money is in your current Acount?: '))
savings_account = float(input('How much money is in your savings Account?: '))
if current_account > 1000 or savings_account > 1500:
    print(f'The fee is 0.15 euro.')
else:
    print('No fee charged.')

# shorter alternative
current_account = float(input('How much money is in your current Acount?: '))
savings_account = float(input('How much money is in your savings Account?: '))
fee = 0.0 if current_account > 1000 or savings_account > 1500 else 0.15
print(f'The fee is {fee}')