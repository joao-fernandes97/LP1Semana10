using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private int targetNumber;
        private IView view;
        
        public Controller(int targetNumber)
        {
            this.targetNumber = targetNumber;
        }
        
        
        private static void Start(IView view)
        {
            this.view = view;
            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            view.WelcomeMsg();

            // Game loop
            while (!guessedCorrectly)
            {
                guess = view.TakeAGuess();
                attempts++;

                if (guess == targetNumber)
                {
                    view.SuccessMsg();
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    view.LowMsg();
                }
                else
                {
                    view.HighMsg();
                }
            }

            view.EndMsg();
        }
    }
}