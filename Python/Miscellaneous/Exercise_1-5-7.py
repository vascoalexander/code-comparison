import random

while True:
    choices = ["rock", "paper", "scissors"]
    player = None
    computer = random.choice(choices)

    while player not in choices:
        player = input("rock, paper, or scissors?: ").lower()

    wincondition = {"paper": "rock", "rock": "scissors", "scissors": "paper"}

    print("computer: " + computer)
    print("player: " + player)

    for key, value in wincondition.items():
        if player == key and computer == value:
            print("You won!")
        elif computer == key and player == value:
            print("You lose!")
        elif player == computer:
            print("Tie!")
            break
    
    play_again = input("Play again?(yes/no): ").lower()

    if play_again != 'yes':
        break

print("Bye")