using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private GuessGame guesser;
        private IView view;
        
        public Controller(GuessGame guesser)
        {
            this.guesser = guesser;
        }
        
        
        public void Start(IView view)
        {
            this.view = view;

            view.WelcomeMsg();

            // Game loop
            while (!guesser.GuessedCorrectly)
                view.AttemptMsg(guesser.GuessMatch(view.TakeAGuess()));

            view.EndMsg();
        }
    }
}