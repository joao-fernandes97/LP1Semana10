using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            // Generate a random number
            Random random = new Random();
            int targetInt = random.Next(1, 101);

            // Generate a number between 1 and 100
            Controller controller = new Controller(targetInt);

            IView view = new ConsoleView(controller, targetInt);

            controller.Start(view);
        }
    }
}