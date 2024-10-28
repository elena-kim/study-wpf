namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NaiveSingleton s1 = NaiveSingleton.Instance;
            NaiveSingleton s2 = NaiveSingleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
