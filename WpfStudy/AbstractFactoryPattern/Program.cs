using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Start making NewYork Pizza!!!");
            string[] firstPizzaToppings = ["pepperoni"];
            ClientMethod(new NewYorkPizzaFactory(), firstPizzaToppings);
            Console.WriteLine();

            Console.WriteLine("Start making Chicago Pizza!!!");
            string[] secondPizzaToppings = ["pepperoni", "minced meat"];
            ClientMethod(new ChicagoPizzaFactory(), secondPizzaToppings);
        }

        public void ClientMethod(IPizzaFactory factory, params string[] toppings)
        {
            var crust = factory.CreateCrust();
            var pizza = factory.CreatePizza();

            crust.AddSauce();
            pizza.AddToppings(toppings);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}