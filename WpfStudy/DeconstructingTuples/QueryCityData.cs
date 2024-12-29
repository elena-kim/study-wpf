namespace DeconstructingTuples
{
    public class QueryCityData
    {
        public (string, int, double) GetData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);

            return ("", 0, 0);
        }

        public (string, double, int, int, int, int) GetDataForYears(string name, int year1, int year2)
        {
            int population1 = 0;
            int population2 = 0;
            double area = 0;

            if (name == "New York City")
            {
                area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }

            return ("", 0, 0, 0, 0, 0);
        }
    }
}
