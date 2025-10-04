# Exercise 1-3-28
for row in range(11):
    for col in range(11):
        if row == 0 or row == 11 - 1 or col == 0 or col == 11 - 1:
            print('o', end='')
        elif row == 5:
            print('X', end='')
        elif col == 5:
            print('X', end='')
        elif row + col == 11 - 1 and row != 0 and row != 11 - 1:
            print('i', end='')
        elif row == col and row != 0 and row != 11 - 1:
            print('i', end='')
        else:
            print('.', end='')
    print()


