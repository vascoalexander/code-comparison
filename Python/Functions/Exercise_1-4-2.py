# Exercise 1-4-2
def element_in_list(lst, element):
    if element in lst:
        return True
    else:
        return False
    
print(element_in_list([1,2,3,4,5,6], 2))
print(element_in_list([3,6,9,7,11], -1))