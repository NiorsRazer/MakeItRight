public class Management_Game
{
    public Joueur[] Joueurs { get; set; } // Array to store two Joueur objects
    public int Goal { get; set; } // Target score to win the game
    public int[] Options { get; set; } // Array to store seven options (possibly answer choices)

       public Management_Game()
    {
        Joueurs = new Joueur[2] { new Joueur(), new Joueur() }; // Initialize Joueurs array with inactive players

        Random random = new Random();

        // Generate random Goal between 1 and 1000 (inclusive)
        Goal = random.Next(1, 1001);

        // Generate unique Options using a HashSet for efficient checking
        HashSet<int> optionSet = new HashSet<int>();
        while (optionSet.Count < 7)
        {
            int option = random.Next(1, 101); // Generate random option between 1 and 100 (inclusive)

            // Check if option is unique and different from Goal
            if (!optionSet.Contains(option) && option != Goal)
            {
                optionSet.Add(option);
            }
        }

        Options = optionSet.ToArray(); // Convert HashSet to options array
    }
}