from random import randint

coins = 10
active = True

while active:
    print(f"You have {coins} left to play!")
    quit = (input("Press Key to continue or enter 'quit' to exit. "))

    if quit == 'quit':
        active = False
    else:
        first = randint(0, 9)
        second = randint(0, 9)
        third = randint(0, 9)
    
        if first == second and first == third:
            coins += 10
            print(f"{first:<3d}{second:<3d}{third:<1d} | You won 10 coins. Coins left: {coins}")
        elif first == second or first == third or second == third:
            coins += 3
            print(f"{first:<3d}{second:<3d}{third:<1d} | You won 3 coins. Coins left: {coins}")
        else:
            print(f"{first:<3d}{second:<3d}{third:<1d} | You lost. Coins left: {coins}")
            coins -= 1
        
        if coins == 0:
            active = False
    
    