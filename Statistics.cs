using System;

public class Statistics
{
    // Variables to store statistics for SevensOut game
    private int SevensOutPlays;
    private int ThreeorMorePlays;
    private int SevensOutHighScore;
    private int ThreeorMoreHighScore;
    private int SevensOutTotalrounds;
    private int ThreeorMoreTotalrounds;
    private int SevensOutTotalscore;
    private int ThreeorMoreTotalscore;

    // Constructor to initialize the statistics
    public Statistics()
    {

        SevensOutPlays = 0;
        ThreeorMorePlays = 0;
        SevensOutHighScore = 0;
        ThreeorMoreHighScore = 0;
        SevensOutTotalrounds = 0;
        ThreeorMoreTotalrounds = 0;
        SevensOutTotalscore = 0;
        ThreeorMoreTotalscore = 0;
    }

    // Method to update statistics for games where three or more were played
    public void UpdateThreeorMoreStatistics(int score, int rounds)
    {
        ThreeorMorePlays++;
        ThreeorMoreTotalrounds += rounds; // Add rounds played to total rounds
        ThreeorMoreTotalscore += score; // Add score to total score
        if (score > ThreeorMoreHighScore) // Update high score if needed
        {
            ThreeorMoreHighScore = score;
        }
    }

    // Method to update statistics for SevensOut game
    public void UpdateSevensOutStatistics(int score, int rounds)
    {
        SevensOutPlays++;
        SevensOutTotalrounds += rounds; // Add rounds played to total rounds
        SevensOutTotalscore += score; // Add score to total score
        if (score > SevensOutHighScore) // Update high score if necessary
        {
            SevensOutHighScore = score;
        }
    }


    public void DisplayStatistics()
    {
        Console.WriteLine("Game Stats:");
        Console.WriteLine($"Total number of plays: {ThreeorMorePlays}");
        Console.WriteLine($"High score: {ThreeorMoreHighScore}");
        Console.WriteLine($"Average score: {(ThreeorMorePlays == 0 ? 0 : ThreeorMoreTotalscore / ThreeorMorePlays)}");
        Console.WriteLine($"Average rounds played before winning: {(ThreeorMorePlays == 0 ? 0 : ThreeorMoreTotalrounds / ThreeorMorePlays)}");
    }
}

