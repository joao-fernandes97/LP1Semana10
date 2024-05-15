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

        
    }
}