namespace DeconstructingTuples
{
    public class DiscardElements
    {
        private QueryCityData query;

        public DiscardElements()
        {
            query = new();
        }

        public void GetPopulationChanges()
        {
            var (_, _, _, pop1, _, pop2) = query.GetDataForYears("New York City", 1960, 2010);
            Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
        }
    }
}
