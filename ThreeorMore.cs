using System;
using System.Collections.Generic;
using System.Linq;

public class ThreeOrMore
{
    private List<Die> dice; // List to hold dice objects
    private Random random; // Random number generator
    private int totalScore; // Total score of the game

    // Constructor initializes Three or More game
    public ThreeOrMore()
    {
        dice = new List<Die>(); // Creates a list to hold dice objects
        random = new Random(); // Initialize the random number generator
        totalScore = 0; // Initialize start total score to 0

        // Create five dice objects and add them to the list
        for (int i = 0; i < 5; i++)
        {
            dice.Add(new Die());
        }
    }


    public void Play()  // Method to start and play the game
    {
        Console.WriteLine("Welcome to Three or More Game.");
        Console.WriteLine("Rolling die...");

        // Game loop continues until total score reaches 20 or more
        while (totalScore < 20)
        {
            Console.ReadLine(); // checks user input if its valid and waits until user input

            Console.WriteLine("Rolling Die...");
            RollDice();

            int score = CalculateScore(); // Calculate the score for the round
            totalScore += score; // Add the round score to total score
            Console.WriteLine($"You have scored {score} points in this round."); // Displays round score
            Console.WriteLine($"Total score: {totalScore}"); // Displays total score
        }

        Console.WriteLine("Well done, you have reached 20 points first."); // lets player know they have won
    }

    // Method to roll all the dice
    private void RollDice()
    {
        // Iterate through each die and roll it
        foreach (var die in dice)
        {
            die.Roll();
        }
    }

    // Method that calculates score based on the rolled dice
    private int CalculateScore()
    {
        int[] counts = new int[6];

        // Count occurrences of each die face
        foreach (var die in dice)
        {
            counts[die.CurrentValue - 1]++;
        }

        int score = 0; // Initialize score to 0

        // Check for three-of-a-kind
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] >= 3)
            {
                score = 3 * (i + 1);
                break;
            }
        }

        // Check for four-of-a-kind or five-of-a-kind if no three-of-a-kind found
        if (score == 0)
        {
            if (counts.Contains(4))
            {
                score = 6; // Score for four-of-a-kind
            }
            else if (counts.Contains(5))
            {
                score = 7; // Score for five-of-a-kind
            }
        }

        return score; // Return the calculated score
    }
}

