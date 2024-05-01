using System;


public class RandomNumberGenerator
{
    protected Random random; // Random number generator

    // Constructor to initialize the random number generator
    public RandomNumberGenerator()
    {
        random = new Random();
    }
}

// Class representing a six-sided die, inheriting from RandomNumberGenerator
public class Die : RandomNumberGenerator
{
    private int currentValue; // Current value of the die


    public Die() : base()
    {
        Roll();
    }

    // Method to roll the die and get the result
    public int Roll()
    {
        currentValue = random.Next(1, 7); // Generate a random number between 1 and 6
        return currentValue; // Return the rolled value
    }
}
