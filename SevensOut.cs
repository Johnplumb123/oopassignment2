using System;

public class SevensOut
{
    private List<Die> dice; // list to hold two dice
    private Random random; // Random number generator
    private int totalScore; // Total score of the game

    // Constructor to initialize the game
    public SevensOut()
    {
        dice = new List<Die>(); // Initialize list to hold dice objects
        random = new Random(); // Initialize random number generator
        totalScore = 0; // Initialize total score to 0

        // Create two dice objects and store them in the array
        for (int i = 0; i < dice.Length; i++)
        {
            dice[i] = new Die();
        }
    }

    // Method that starts and to play the game
    public void Play()
    {
        Console.WriteLine("Welcome to sevens out game.");
        Console.WriteLine("Rolling Die...");

        // Game loop
        while (true)
        {
            Console.ReadLine(); // checks user input if its valid and waits until user input

            Console.WriteLine("Rolling Die...");

            int rollTotal = RollDice(); // Roll the dice and get the total
            if (rollTotal == 7) // Check if the total is 7
            {
                Console.WriteLine("You have rolled a 7, game over.");
                break;
            }
            else
            {
                totalScore += rollTotal; // Add roll total to total score

                // Check if both dice have the same value and add to total score
                if (dice[0].CurrentValue == dice[1].CurrentValue)
                {
                    totalScore += rollTotal;
                }

                Console.WriteLine($"You have rolled a total of {rollTotal}. Total score: {totalScore}");
            }
        }
    }

    // Method to roll the dice and calculate the total
    private int RollDice()
    {
        int rollTotal = 0;
        foreach (var die in dice) // Loop through each die
        {
            rollTotal += die.Value; // Add the value of each die to the roll total
        }
        return rollTotal; // Return the total value of the dice
    }
}

