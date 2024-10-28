namespace FactoryMethodPattern
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Truck Delivery Start");
        }
    }
}
