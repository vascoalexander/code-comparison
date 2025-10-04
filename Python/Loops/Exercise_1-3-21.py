# Exercise 1-3-21
for row in range(7):
    for column in range(7):
        if row == column:
            print("X", end="")
        elif column == 3:
            print("X", end="")
        else:
            print("-", end="")
    print()