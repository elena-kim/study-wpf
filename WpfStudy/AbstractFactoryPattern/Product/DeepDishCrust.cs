namespace AbstractFactoryPattern.Product
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class DeepDishCrust : ICrust
    {
        public void AddSauce()
        {
            Console.WriteLine("[Deep Dish Pizza] add sauce");
        }
    }
}
