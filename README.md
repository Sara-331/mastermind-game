This is a console-based version of the Mastermind game, written in C#.

The game generates a secret code made of 4 distinct digits from 0 to 8. The player has a limited number of attempts to guess the correct code. After each guess, the program shows how many digits are well-placed (correct position) and how many are misplaced (correct digit but wrong position). 

You can start the game using the command line with optional parameters:
- -c [CODE] to set a custom secret code (like -c 0123)
- -t [ATTEMPTS] to set number of attempts (default is 10)

Example:

When the game starts, it displays:
"Can you break the code? Enter a valid guess."

If the guess is correct, it shows:
"Congratz! You did it!"

If the guess is invalid or incorrect, it will show how many well-placed and misplaced digits.

Developed by Sara AlSuhaibani for the Savvy Kickstarter Program - Gameplay Programming Track.
