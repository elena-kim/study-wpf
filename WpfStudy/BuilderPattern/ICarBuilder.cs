namespace BuilderPattern
{
    public interface ICarBuilder
    {
        ICarBuilder SetSeats(int seats);
        ICarBuilder SetEngine(string engine);  
        Car Build();
    }
}
