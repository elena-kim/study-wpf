namespace BuilderPattern
{
    public class CarDirector
    {
        private ICarBuilder _builder;

        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public Car BuildDefaultCar()
        {
            return _builder.SetEngine("default")
                .SetSeats(4)
                .Build();
        }
    }
}
