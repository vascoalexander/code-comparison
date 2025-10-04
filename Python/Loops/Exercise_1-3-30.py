# Exercise 1-3-30
for row in range(11):
    for col in range(11):
        if row <= 5:
            distance = 5 - row
        else:
            distance = row - 5
        if col == distance or col == 11 - distance - 1:
            print('o', end='')
        else:
            print(' ', end='')
    print()

