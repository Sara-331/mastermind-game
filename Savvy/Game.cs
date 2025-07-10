public class Game
{
    private SecretCode secretCode;
    private int maxAttempts;

    public Game(string code = null, int attempts = 10)
    {
        secretCode = new SecretCode(code);
        maxAttempts = attempts;
    }

    public void Start()
    {
        Console.WriteLine("Can you break the code? Enter a valid guess.");

        int round = 0;

        while (round < maxAttempts)
        {
            Console.WriteLine($"---\nRound {round}");
            Console.Write(">");

            string input = Console.ReadLine();

            if (input == null)
                return;

            if (!IsValidInput(input))
            {
                Console.WriteLine("Wrong input!");
                continue;
            }

            if (input == secretCode.Code)
            {
                Console.WriteLine("Congratz! You did it!");
                return;
            }

            var (well, misplaced) = secretCode.EvaluateGuess(input);
            Console.WriteLine($"Well placed pieces: {well}");
            Console.WriteLine($"Misplaced pieces: {misplaced}");
            round++;
        }

        Console.WriteLine("Game over! The code was: " + secretCode.Code);
    }

    private bool IsValidInput(string input)
    {
        return input.Length == 4 &&
               int.TryParse(input, out _) &&
               input.Distinct().Count() == 4 &&
               input.All(c => "012345678".Contains(c));
    }
}
