# Exercise 1-3-26
for row in range(1,8):
    for column in range(1,8):
        if row < 4:
            if column == row or column + row == 8:
                print('X', end='')
            else:
                print('-', end='')
        else:
            if column >= 4 - (row - 4) and column < 4 + (row - 4) + 1:
                print('X', end='')
            else:
                print('-', end='')
    print()