using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class ConsoleView : IView
    {
        private readonly Controller controller;

        private readonly List<Player> playerList;

        public ConsoleView(Controller controller, List<Player> playerList){
            this.controller = controller;
            this.playerList = playerList;
        }

        /// <summary>
        /// Shows the main menu.
        /// </summary>
        public int ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");

            return int.Parse(Console.ReadLine());
        }

        public Player CreatePlayer()
        {
            // Variables
            string name;
            int score;

            // Ask for player info
            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            // Create new player and add it to list
            return new Player(name, score);
        }

        /// <summary>
        /// Show all players in a list of players. This method can be static
        /// because it doesn't depend on anything associated with an instance
        /// of the program. Namely, the list of players is given as a parameter
        /// to this method.
        /// </summary>
        /// <param name="playersToList">
        /// An enumerable object of players to show.
        /// </param>
        public void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");

            // Show each player in the enumerable object
            foreach (Player p in playersToList)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }
            Console.WriteLine();
        }

        public int AskMinScore()
        {
            // Ask the user what is the minimum score
            Console.Write("\nMinimum score player should have? ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public PlayerOrder AskSortOrder()
        {
            Console.WriteLine("Player order");
            Console.WriteLine("------------");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByScore}. Order by score");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByName}. Order by name");
            Console.WriteLine(
                $"{(int)PlayerOrder.ByNameReverse}. Order by name (reverse)");
            Console.WriteLine("");
            Console.Write("> ");

            return Enum.Parse<PlayerOrder>(Console.ReadLine());
        }

        public void InvalidOptionMsg()
        {
            Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
        }

        // Wait for user to press a key...
        public void ConfirmMsg()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n");
        }

        public void ClosingMsg()
        {
            Console.WriteLine("Bye!");
        }
            
                
        
    }
}