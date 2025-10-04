# Exercise 1-3-24
for row in range(8):
    for column in range(8):
        if (row <= 3 and column <= 3) or (row >= 4 and column >= 4):
            print(".", end="")
        else:
            print("=", end="")      
    print()