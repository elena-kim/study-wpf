namespace AbstractFactoryPattern.Product
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface IPizza
    {
        void AddToppings(params string[] toppings);
    }
}
