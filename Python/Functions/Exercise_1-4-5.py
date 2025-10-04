# Exercise 1-4-5
def maximum(lst):
    currentMax = lst[0]
    for item in lst:
        if item > currentMax:
            currentMax = item
    return currentMax

print(maximum([-9,2,4,1,8]))
print(maximum([-3,1,7,6,-4,3]))