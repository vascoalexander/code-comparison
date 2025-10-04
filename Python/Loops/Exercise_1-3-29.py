# Exercise 1-3-29
for row in range(7):
    for col in range(7):
        if row == col or row + col == 6:
            print('*', end='')
        elif col == 0 or col == 6:
            print('*', end='')
        else:
            print(' ', end='')
    print()

