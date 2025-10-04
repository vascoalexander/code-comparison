# Exercise 1-3-9
for row in range(7):
    for column in range(7):
        if row == column:
            print("X", end="")
        else:
            print("-", end="")
    print()

# scaleable
size = int(input("Enter size: "))
for row in range(size):
    for column in range(size):
        if row == column:
            print("X", end="")
        else:
            print("-", end="")
    print()