using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            GuessGame guesser = new GuessGame();

            // Generate a number between 1 and 100
            Controller controller = new Controller(guesser);

            IView view = new ConsoleView(controller, guesser);

            controller.Start(view);
        }
    }
}