
public class SecretCode
{
    public string Code { get; private set; }

    public SecretCode(string customCode = null) //Checks if it is valid using IsValid()
    {
        if (!string.IsNullOrEmpty(customCode))
        {
            if (IsValid(customCode))
                Code = customCode;
            else
                throw new ArgumentException("Invalid code.");
        }
        else
        {
            Code = GenerateRandomCode();
        }
    }

    private bool IsValid(string code)
    {
        return code.Length == 4 &&
               code.All(char.IsDigit) &&
               code.Distinct().Count() == 4 &&
               code.All(c => "012345678".Contains(c));
    }

    private string GenerateRandomCode() //Generate random code
    {
        var digits = "012345678".ToList();
        var rnd = new Random();
        string result = "";

        while (result.Length < 4)
        {
            var c = digits[rnd.Next(digits.Count)];
            if (!result.Contains(c))
                result += c;
        }

        return result;
    }

    public (int wellPlaced, int misplaced) EvaluateGuess(string guess) //Rate the player's guess
    {
        int wellPlaced = 0;
        int misplaced = 0;

        for (int i = 0; i < 4; i++)
        {
            if (guess[i] == Code[i])
                wellPlaced++;
            else if (Code.Contains(guess[i]))
                misplaced++;
        }

        return (wellPlaced, misplaced);
    }
}
