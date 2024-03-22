namespace iabilet.service
{
    public interface IObservable
    {
        void AddObserver(IObserver o);
        void DeleteObserver(IObserver o);
        void Notify();
    }
}