# Exercise 1-3-10
for row in range(1,8):
    for column in range(1,8):
        if row == column or row + column == 8:
            print("X", end="")
        else:
            print("-", end="")
    print()

# scaleable
size = int(input("Enter size: "))
for row in range(1, size):
    for column in range(1, size):
        if row == column or row + column == size:
            print("X", end="")
        else:
            print("-", end="")
    print()