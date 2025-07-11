public class Game
{
    private SecretCode secretCode;
    private int maxAttempts;//Maximum attempts = 10

    public Game(string code = null, int attempts = 10)
    {
        secretCode = new SecretCode(code);//There is a code coming from -c that it puts, and if there is no code it generates random code
        maxAttempts = attempts; 
    }

    public void Start()
    {
        Console.WriteLine("Can you break the code? Enter a valid guess."); //Starting message

        int round = 0;

        while (round < maxAttempts)// As long as the player has not finished his attempts continue
        {
            Console.WriteLine($"---\nRound {round}"); //Prints the round number
            Console.Write(">");

            string input = Console.ReadLine(); 

            if (input == null) //If you press Ctrl+D the game ends
                return;

            if (!IsValidInput(input)) //If the entry is incorrect (less than/more than 4 digits – repeating – outside 0-8) 
            {
                Console.WriteLine("Wrong input!");
                continue;
            }

            if (input == secretCode.Code)//If the entry matches the secret code
            {
                Console.WriteLine("Congratz! You did it!");
                return;
            }

            var (well, misplaced) = secretCode.EvaluateGuess(input);// Evaluate the guess using EvaluateGuess() and print the number of correct and incorrect pieces
            Console.WriteLine($"Well placed pieces: {well}");
            Console.WriteLine($"Misplaced pieces: {misplaced}");
            round++;
        }

        Console.WriteLine("Game over! The code was: " + secretCode.Code);// If the player is unable to discover the code during all attempts, the correct code is typed and the game is over
    }

    private bool IsValidInput(string input)
    {
        return input.Length == 4 &&
               int.TryParse(input, out _) &&//This means that all letters must be numbers
               input.Distinct().Count() == 4 && //Each number must be different
               input.All(c => "012345678".Contains(c));//Each number must be from 0 to 8 only
    }
}
