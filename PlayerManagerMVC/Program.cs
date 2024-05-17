using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class Program
    {
        private static void Main(string[] args){

            // Initialize the player list with two players using collection
            // initialization syntax
            List<Player> playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };

            Controller controller= new Controller(playerList);

            IView view = new ConsoleView(controller,playerList);

            controller.Start(view);
        }
    }
}