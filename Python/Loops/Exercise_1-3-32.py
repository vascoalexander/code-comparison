# Exercise 1-3-32
for i in range(1,21):
    if (i+(i+1)) % 5 == 0 or (i + (i-1)) % 5 == 0:
        print(i + 500, end=" ")
    else:
        print(i, end=" ")
print()

# alternative
for i in range(1,21):
    if i % 5 == 2 or i % 5 == 3:
        print(i + 500, end=" ")
    else:
        print(i, end=" ")
