namespace Zoork.Interfaces
{
    public interface IState
    {
        void Do(Context context);

        string Say();
    }
}