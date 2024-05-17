using System;

namespace GuessTheNumber
{
    public class ConsoleView : IView
    {
        private readonly Controller controller;

        private readonly GuessGame guesser;

        public ConsoleView(Controller controller, GuessGame guesser){
            this.controller = controller;
            this.guesser = guesser;
        }
        
        public void WelcomeMsg()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public int TakeAGuess()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        /* public void SuccessMsg(int attempts)
        {
            Console.WriteLine(
                "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        } */

        public void AttemptMsg(string msg)
        {
            Console.WriteLine(msg);
        }

        /* public void HighMsg()
        {
            Console.WriteLine();
        } */

        public void EndMsg()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}