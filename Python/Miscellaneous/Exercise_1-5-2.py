# Exercise 1-5-2
name = 'Julien'
age = 32
language = 'Python'

# with f-string
print(f"My name is {name} and I am {age} Years old. I am learning the programming \
language {language}.")

# with string concatenation
print("My name is " + name + " and i am " + str(age) + " Years old. I am learning \
the programming language " + language + ".")

# with multiple arguments
print("My name is ", name, " and I am ", age, " Years old. I am learning the \
programming language ", language, ".", sep="")