# Exercise 1-2-3
weight = float(input('Enter your weight(in kg): '))
weight *= 2

if weight > 235 and 265 > weight:
    elegible = ""
else:
    elegible = "not "

message = f"You are {elegible}eligble to enter the Competiton"
print(message)

# shorter alternative
weight = float(input('Enter your weight(in kg): '))*2
elegible = "" if weight > 235 and 265 > weight else "not "
print(f"You are {elegible}eligble to enter the Competiton")