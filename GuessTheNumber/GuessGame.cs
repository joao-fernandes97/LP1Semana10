using System;

namespace GuessTheNumber
{

    public class GuessGame
    {
        private int targetInt;
        private int attempts = 0;
        public bool GuessedCorrectly {get; set;} = false;

        public GuessGame()
        {
            // Generate a random number
            Random random = new Random();
            targetInt = random.Next(1, 101);
        }

        public void IncreaseAttempts()
        {
            attempts++;
        }

        public string GuessMatch(int guess)
        {
            IncreaseAttempts();
            if (guess-targetInt==0)
            {
                GuessedCorrectly = true;
                return "Congratulations! You guessed the number correctly!\n"+
                "Number of attempts: " + attempts;
            }
            return guess-targetInt<0 ? "Too low! Try again." : "Too high! Try again.";

        }
        
    }

}