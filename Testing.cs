using System;

public class Testing
{
    // Method to run tests for both SevensOut and ThreeorMore games
    public void Tests()
    {
        TestSevensOut(); // Run tests for SevensOut game
        TestThreeorMore(); // Run tests for ThreeorMore game
    }

    // Method to run tests for SevensOut game
    private void TestSevensOut()
    {
        // instance for SevensOut game
        SevensOut sevensOutGame = new SevensOut();


        Debug.Assert(sevensOutGame.PlayTest() <= 7, "Sevens out game test failed as total score exceeds 7.");


        Debug.Assert(sevensOutGame.PlayTest() == 7, "Sevens out game test failed, game doesn't end when total is 7.");
    }

    // Method to run tests for ThreeorMore game
    private void TestThreeorMore()
    {
        // Create an instance of ThreeorMore game
        ThreeorMore threeorMoreGame = new ThreeorMore();

        // Test if total score of a game is less than or equal to 20
        Debug.Assert(threeorMoreGame.PlayTest() <= 20, "Three or More game test failed, total score exceeds 20.");

        // Test if the game ends when the total score is 20
        Debug.Assert(threeOrMoreGame.PlayTest() == 20, "Three or More game test failed, game doesn't end when total is 20.");

        // Test if scoring combinations are calculated correctly
        Debug.Assert(threeOrMoreGame.TestCombinationsScoring() == true, "Three or More test failed, die combination scoring error.");

        // Test if die reroll works 
        Debug.Assert(threeOrMoreGame.TestRoll() == true, "Three or More test failed: Die Reroll error.");

        // Test if 3-of-a-kind scoring works 
        Debug.Assert(threeOrMoreGame.TestThreeOfAKind() == true, "Three or More test failed: 3-of-a-kind scoring error.");

        // Test if 4-of-a-kind scoring works 
        Debug.Assert(threeOrMoreGame.TestFourOfAKind() == true, "Three or More test failed: 4-of-a-kind scoring error.");

        // Test if 5-of-a-kind scoring works 
        Debug.Assert(threeOrMoreGame.TestFiveOfAKind() == true, "Three or More test failed: 5-of-a-kind scoring error.");
    }
}

