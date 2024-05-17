namespace GuessTheNumber
{
    public interface IView
    {
        void WelcomeMsg(); 
        int TakeAGuess();
        void SuccessMsg(int attempts);
        void LowMsg();
        void HighMsg();
        void EndMsg();  
    }
}
