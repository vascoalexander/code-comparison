# Exercise 1-3-23
for row in range(8):
    for column in range(8):
        if row <= 3 and column <= 3:
            print(".", end="")
        else:
            print("=", end="")
    print()