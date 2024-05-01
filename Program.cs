using System;

class game
{
    // Main method, entry point of the program
    static void Main(string[] args)
    {
        // instance of  Game class
        Game game = new Game();

        game.Start();
    }
}

using static SevensOutGame;

// Abstract base class for defining game behavior
public abstract class GameBase
{
    // Abstract method for playing the game, to be implemented by derived classes
    public abstract void Play();
}

// Concrete class for the SevensOut game, inheriting from GameBase(use of inheritance)
public class SevensOutGame : GameBase
{
    private SevensOut sevensOutGame; // Instance of the SevensOut game

    // Constructor to initialize the SevensOut game
    public SevensOutGame()
    {
        sevensOutGame = new SevensOut();
    }

    // Implementation of the Play method for the SevensOut game
    public override void Play()
    {
        sevensOutGame.Play(); // Play the SevensOut game
        Console.Clear(); // Clear the console after playing
    }
}

// Concrete class for the ThreeorMore game, inheriting from GameBase
public class ThreeOrMoreGame : GameBase
{
    private ThreeOrMore threeOrMoreGame; // Instance of the ThreeOrMore game

    // Constructor to initialize the ThreeOrMore game
    public ThreeOrMoreGame()
    {
        threeOrMoreGame = new ThreeOrMore();
    }

    // Implementation of the Play method for the ThreeOrMore game
    public override void Play()
    {
        threeOrMoreGame.Play(); // Play the ThreeOrMore game
        Console.Clear(); // Clear the console after playing
    }
}

// Class for managing different games and user interactions
public class Game
{
    private GameBase[] games;
    private Statistics statistics;
    private Testing testing;


    public Game()
    {
        // Initialize array of games and other components
        games = new GameBase[] { new SevensOutGame(), new ThreeOrMoreGame() };
        statistics = new Statistics();
        testing = new Testing();
    }

    // Method to start the game loop and handle user input
    public void Start()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to the Dice Games!");
            Console.WriteLine("1. Play Sevens Out Game");
            Console.WriteLine("2. Play Three or More Game");
            Console.WriteLine("3. View Statistics");
            Console.WriteLine("4. Perform Tests");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    games[0].Play(); // Play the SevensOut game
                    break;
                case "2":
                    Console.Clear();
                    games[1].Play(); // Play the ThreeOrMore game
                    break;
                case "3":
                    Console.Clear();
                    statistics.DisplayStatistics();
                    break;
                case "4":
                    Console.Clear();
                    testing.PerformTests();
                    break;
                case "5":
                    exit = true; // Exits the game loop
                    break;
                default:
                    Console.WriteLine("You have entered an invalid option, please choose again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
