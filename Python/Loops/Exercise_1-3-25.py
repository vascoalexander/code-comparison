# Exercise 1-3-25
for row in range(1,8):
    for column in range(1,8):
        if row == column or row + column == 8:
            print("X", end="")
        elif row == 4 or column == 4:
            print("X", end="")
        else:
            print("-", end="")
    print()