# Exercise 1-2-8
money = float(input('Enter the amount to be converted: '))
convert_to = input('Convert to? (e for euro or d for dm)')
if convert_to == 'e' or convert_to == 'E':
    print(f'{money} DM are {(money / 1.95583):.2f} in Euro.')
elif convert_to == 'd' or convert_to == 'D':
    print(f'{money} Euro are {(money * 1.95583):.2f} in DM')
else:
    print('Invalid input. Exit program!')
    exit()