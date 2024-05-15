using System.Collections.Generic;

namespace PlayerManager4
{
    public interface IView
    {
        int ShowMenu();

        Player CreatePlayer();

        void ListPlayers(IEnumerable<Player> playersToList);

        int AskMinScore();

        PlayerOrder AskSortOrder();

        void InvalidOptionMsg();

        void ConfirmMsg();
    }
}