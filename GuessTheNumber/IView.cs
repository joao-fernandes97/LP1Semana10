namespace GuessTheNumber
{
    public interface IView
    {
        void WelcomeMsg(); 
        int TakeAGuess();
        void AttemptMsg(string msg);
        void EndMsg();  
    }
}
