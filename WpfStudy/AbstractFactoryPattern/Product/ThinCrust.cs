namespace AbstractFactoryPattern.Product
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class ThinCrust : ICrust
    {
        public void AddSauce()
        {
            Console.WriteLine("[Thin Pizza] add sauce");
        }
    }
}
