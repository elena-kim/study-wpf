using System.Reflection;

namespace DeconstructingTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

            // Deconstruct the person object.
            var (fName, lName, city, state) = p;
            Console.WriteLine($"Hello {fName} {lName} of {city}, {state}!");

            // Deconstruction extension methods
            Type dateType = typeof(DateTime);
            PropertyInfo prop = dateType.GetProperty("Now");
            var (isStatic, isRO, isIndexed, propType) = prop;
            Console.WriteLine($"\nThe {dateType.FullName}.{prop.Name} property:");
            Console.WriteLine($"   PropertyType: {propType.Name}");
            Console.WriteLine($"   Static:       {isStatic}");
            Console.WriteLine($"   Read-only:    {isRO}");
            Console.WriteLine($"   Indexed:      {isIndexed}");
        }
    }
}
