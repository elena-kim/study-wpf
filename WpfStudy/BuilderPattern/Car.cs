namespace BuilderPattern
{
    public class Car
    {
        private int _seats;
        private string _engine;

        public Car(int seats, string engine)
        {
            _seats = seats;
            _engine = engine;
        }

        public override string ToString()
        {
            return $"seats: {_seats} engine: {_engine}";
        }
    }
}
