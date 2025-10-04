# Exercise 1-3-11
for row in range(1, 8):
    for column in range(1, 8):
        if row < 4 and row == column:
            print("X", end="")
        elif row == 4 and column > 3:
            print("X", end="")
        elif row > 4 and row + column == 8:
            print("X", end="")
        else:
            print("-", end="")
    print()