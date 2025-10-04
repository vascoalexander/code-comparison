# Exercise 1-5-6
check_prime = int(input('Enter a positive number higher than 1: '))
prime = True

if check_prime < 2:
    print('Invalid Input')
    exit()

else:
    for i in range(2,check_prime//2+1):
        if check_prime % i == 0:
            prime = False
            print(f'{check_prime} is not a prime number')
            break
    if prime == True:
        print(f'{check_prime} is a prime number.')

# shorter alternative with for-else block
check_prime = int(input('Enter a positive number higher than 1: '))

if check_prime < 2:
    print('Invalid Input')
else:
    for i in range(2, int(check_prime ** 0.5) + 1):
        if check_prime % i == 0:
            print(f'{check_prime} is not a prime number')
            break
    else:
        print(f'{check_prime} is a prime number.')

# short and more elegant solution
check_prime = int(input('Enter a positive number higher than 1: '))
prime = ""

if check_prime < 2:
    prime = "not "
else:
    for i in range(2,int(check_prime**0.5)+1):
        if check_prime % i == 0:
            prime = "not "
            break

print(f'{check_prime} is {prime}a prime number.')
    
    

