using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class ChicagoPizzaFactory : IPizzaFactory
    {
        public ICrust CreateCrust()
        {
            return new DeepDishCrust();
        }

        public IPizza CreatePizza()
        {
            return new ChicagoPizza();
        }
    }
}
