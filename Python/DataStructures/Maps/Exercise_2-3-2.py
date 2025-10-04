# Exercise 2-3-2
dict = {'apple': 15, 'banana': 8, 'cutter': 12, 'kiwi': 9, 'peach': 2}
sum = 0
for value in dict.values():
    sum += value
print(f"The sum of the values in the dictionary is: {sum}")

# alternative without values()
sum_alt = 0
for i in dict:
    sum_alt += dict[i]
print(f"The sum of the values in the dictionary is: {sum_alt}")