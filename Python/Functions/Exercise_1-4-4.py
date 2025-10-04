# Exercise 1-4-4
def remove_duplicates(lst):
    newList = sorted(set(lst))
    return newList

print(remove_duplicates([0,3,5,7,3,5,1,-1]))
print(remove_duplicates([0,5,9,10,3,2,1,-3]))