# Exercise 1-3-19
for j in range(8):
    for i in range(5,21):
        if i < 10:
            print(f"{i:<2}", end="")
        else:
            print(f"{i:<3}", end="")
    print()

