# Exercise 1-3-36
for row in range(7):
    for column in range(9):
        if row % 2 == 0 and column % 2 == 0:
            print("X", end="")
        elif row % 2 != 0 and column % 2 != 0:
            print("X", end="")
        else:
            print(" ", end="")
    print()
    