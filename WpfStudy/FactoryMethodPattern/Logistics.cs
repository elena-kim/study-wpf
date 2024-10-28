namespace FactoryMethodPattern
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();
    }
}
