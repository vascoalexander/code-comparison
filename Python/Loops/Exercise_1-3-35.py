# Exercise 1-3-35
counter = 0
for i in range(1000):
    if '7' not in str(i):
        print(f"{i:>4}", end="")
        counter += 1
        if counter == 10:
            print()
            counter = 0  