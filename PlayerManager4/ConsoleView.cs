using System;
using System.Collections.Generic;

namespace PlayerManager4
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
        
    }
}