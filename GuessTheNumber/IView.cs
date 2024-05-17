namespace GuessTheNumber
{
    public interface IView
    {
        void WelcomeMsg(); 
        int TakeAGuess();
        void SuccessMsg();
        void LowMsg();
        void HighMsg();
        void EndMsg();  
    }
}
