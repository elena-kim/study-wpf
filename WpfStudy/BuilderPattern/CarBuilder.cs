namespace BuilderPattern
{
    public class CarBuilder : ICarBuilder
    {
        private int _seats;
        private string _engine;

        public ICarBuilder SetEngine(string engine)
        {
            _engine = engine;
            return this;
        }

        public ICarBuilder SetSeats(int seats)
        {
            _seats = seats;
            return this;
        }

        public Car Build()
        {
            return new Car(_seats, _engine);
        }
    }
}
