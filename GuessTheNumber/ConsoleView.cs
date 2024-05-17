namespace GuessTheNumber
{
    public class ConsoleView : IView
    {
        private readonly Controller controller;

        private readonly int targetInt;

        public ConsoleView(Controller controller, List<Player> targetInt){
            this.controller = controller;
            this.targetInt = targetInt;
        }
        
        public void WelcomeMsg()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }
    
    }
}