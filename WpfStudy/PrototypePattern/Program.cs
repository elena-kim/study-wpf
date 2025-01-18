namespace PrototypePattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            ColorManager colormanager = new();
            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);
          
            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["green"].Clone() as Color;
            Color color3 = colormanager["blue"].Clone() as Color;

            // Wait for user
            Console.ReadKey();
        }
    }
}
