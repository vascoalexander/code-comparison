# Exercise 1-4-6
def minimum(lst):
    currentMin = lst[0]
    for item in lst:
        if item < currentMin:
            currentMin = item
    return currentMin

print(minimum([-9,2,4,1,8]))
print(minimum([-3,1,7,6,-4,3]))