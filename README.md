# Mastermind Game

A simple and interactive console based game built in C#.

This game challenges the player to guess a secret 4-digit code, made up of distinct numbers from 0 to 8 The player has a limited number of attempts to crack the code. After each guess, the program gives helpful feedback:

- Well placed digits → correct number in the correct position.  
- Misplaced digits → correct number in the wrong position.

 How to Play

1. The game launches with the message:  
   "Can you break the code? Enter a valid guess."

2. The player enters a 4-digit guess (`1234`).

3. Based on the input, the game displays:
   - How many digits are well placed.
   - How many digits are misplaced.
   - If the guess is incorrect, the player tries again.
   - If the guess is correct, the game prints:  
     "Congratz! You did it!"

---

##  How to Run

From the terminal or Git Bash, use:

```bash
dotnet run -- -c 0123 -t 10

-c [CODE] — optional: set a custom secret code

-t [ATTEMPTS] — optional: set a custom number of attempts

If not specified, a random code is generated and the player has 10 attempts


