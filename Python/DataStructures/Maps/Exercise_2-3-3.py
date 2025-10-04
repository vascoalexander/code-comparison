# Exercise 2-3-3
def add_to_dictionary(element_key, element_value, d):
    d[element_key] = element_value
    return d

print(add_to_dictionary("baptiste", 29, {"julien": 14, "laurent":31}))  
print(add_to_dictionary("Gewicht", 65.3, {}))