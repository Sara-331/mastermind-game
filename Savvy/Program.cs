class Program
{
    static void Main(string[] args)
    {
        string secretCode = null; 
        int attempts = 10; 

        for (int i = 0; i < args.Length; i++)
    
        {
            if (args[i] == "-c" && i + 1 < args.Length)
             // Searches args for the -c option if found, takes the number after it and stores it in secretCode
                secretCode = args[i + 1];
            else if (args[i] == "-t" && i + 1 < args.Length)
            //Looks for -t and takes the number after it and converts it to an int in attempts
                int.TryParse(args[i + 1], out attempts);
        }

        Game game = new Game(secretCode, attempts);// Creates a game object from the Game class, and sends it the secret code and the number of attempts
        game.Start();
    }
}
