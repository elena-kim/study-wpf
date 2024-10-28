namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics firstLogistic = new RoadLogistics();
            ITransport roadLogistic = firstLogistic.CreateTransport();
            roadLogistic.Deliver();

            Logistics secondLogistic = new SeaLogistics();
            ITransport seaLogistic = secondLogistic.CreateTransport();
            seaLogistic.Deliver();
        }
    }
}
