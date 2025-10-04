# Exercise 1-3-8
for row in range(7):
    for column in range(7):
        print("X", end="")
    print()

# scaleable
size = int(input("Enter size: "))
for row in range(size):
    for column in range(size):
        print("X", end="")
    print()