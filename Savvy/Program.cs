class Program
{
    static void Main(string[] args)
    {
        string secretCode = null;
        int attempts = 10;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "-c" && i + 1 < args.Length)
                secretCode = args[i + 1];
            else if (args[i] == "-t" && i + 1 < args.Length)
                int.TryParse(args[i + 1], out attempts);
        }

        Game game = new Game(secretCode, attempts);
        game.Start();
    }
}
