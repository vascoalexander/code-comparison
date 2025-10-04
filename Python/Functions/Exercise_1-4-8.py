# Exercise 1-4-8
def length(lst):
    counter = 0
    for item in lst:
        counter += 1
    return counter

print(length([2,7,23,44,1,0]))
print(length([]))