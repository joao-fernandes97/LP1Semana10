using System;

namespace GuessTheNumber
{
    public class ConsoleView : IView
    {
        private readonly Controller controller;

        private readonly int targetInt;

        public ConsoleView(Controller controller, int targetInt){
            this.controller = controller;
            this.targetInt = targetInt;
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

        public void SuccessMsg(int attempts)
        {
            Console.WriteLine(
                "Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void LowMsg()
        {
            Console.WriteLine("Too low! Try again.");
        }

        public void HighMsg()
        {
            Console.WriteLine("Too high! Try again.");
        }

        public void EndMsg()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}