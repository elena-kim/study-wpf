namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new();
            CarDirector director = new(builder);

            Car noDirected = builder.Build();
            Car defaultCar = director.BuildDefaultCar();
            Car sportsCar = builder.SetSeats(2)
                .SetEngine("sportEngine")
                .Build();

            Console.WriteLine(noDirected);
            Console.WriteLine(defaultCar);
            Console.WriteLine(sportsCar);
        }
    }
}
