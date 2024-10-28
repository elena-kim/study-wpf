namespace FactoryMethodPattern
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Ship Delivery Start");
        }
    }
}
