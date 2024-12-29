namespace DeconstructingTuples
{
    public class BasicDeconstructing
    {
        private QueryCityData query;

        public BasicDeconstructing()
        {
            query = new();
        }

        public void ExplicitDeclare()
        {
            (string city, int population, double area) = query.GetData("New York City");
            Console.WriteLine($"Explicit Declare: {city}\npop:{population}\narea:{area}");
        }

        public void UsingVarKeyword()
        {
            var (city, population, area) = query.GetData("New York City");
            Console.WriteLine($"Using Var Keyword: {city}\npop:{population}\narea:{area}");
        }

        public void AlreadyDeclaredVariables()
        {
            string city = "Raleigh";
            int population = 458880;
            double area = 144.8;

            (city, population, area) = query.GetData("New York City");
            Console.WriteLine($"Already Declared Variables: {city}\npop:{population}\narea:{area}");
        }
    }
}
