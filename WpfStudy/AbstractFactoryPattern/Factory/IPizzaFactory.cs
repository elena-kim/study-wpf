using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IPizzaFactory
    {
        ICrust CreateCrust();
        IPizza CreatePizza();
    }
}
