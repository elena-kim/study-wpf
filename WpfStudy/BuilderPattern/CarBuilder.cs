namespace BuilderPattern
{
    public class CarBuilder : ICarBuilder
    {
        private int _seats { get; set; }
        private string _engine { get; set; }

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
