# Exercise 1-3-15

# my solution
for row in range(1,13,2):
    stars = '*'*(row)
    print(f"{stars:^11}")
for row in range(1,4):
    print(f'{"***":^11}')

# adams solution #1
for i in range(6):               
    for j in range(5-i):    
        print(" ",end="")
    for k in range(2*i+1):
        print("*",end="")   
    print()                 
for i in range(3):          
    for j in range(4):      
        print(" ",end="")
    for k in range(3):      
        print("*",end="")
    print()           

# adams solution #2
for i in range(6):                      
    print(" "*(5-i),"*"*(2*i+1),sep="")
for i in range(3):                    
    print(" "*4,"*"*3,sep="")


# chat-GPT solution
def tree(height):
    for i in range(height):
        stars = '*' * (2 * i + 1)
        spaces = ' ' * (height - i - 1)
        print(spaces + stars)

    for i in range(3):
        spaces = ' ' * (height - 2)
        print(spaces + '***')

height = 6
tree(height)

