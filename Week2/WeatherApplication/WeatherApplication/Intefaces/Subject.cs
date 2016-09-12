namespace WeatherApplication.Intefaces
{
    public interface Subject
    {
        void Attach(ObserverPush ob);
        void Detach(ObserverPush ob);
        void Attach(ObserverPull ob);
        void Detach(ObserverPull ob);
        void Notify();

    }
}
