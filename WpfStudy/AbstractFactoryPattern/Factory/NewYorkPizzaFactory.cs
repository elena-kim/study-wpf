using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class NewYorkPizzaFactory : IPizzaFactory
    {
        public ICrust CreateCrust()
        {
            return new ThinCrust();
        }

        public IPizza CreatePizza()
        {
            return new NewYorkPizza();
        }
    }
}
