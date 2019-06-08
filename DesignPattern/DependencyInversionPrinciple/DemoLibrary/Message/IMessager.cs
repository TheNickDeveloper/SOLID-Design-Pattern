namespace DemoLibrary
{
    public interface IMessager
    {
        void SendMessage(IPerson person, string message);
    }
}