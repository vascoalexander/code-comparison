# Exercise 1-3-27
for row in range(1, 5):
    for column in range(row):
        print("*", end="")
    for column in range(2 * (4 - row)):
        print(" ", end="")
    for column in range(row):
        print("*", end="")
    print()

# Print the lower half
for row in range(3, 0, -1):
    for column in range(row):
        print("*", end="")
    for column in range(2 * (4 - row)):
        print(" ", end="")
    for column in range(row):
        print("*", end="")
    print()

