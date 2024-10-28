namespace SingletonPattern
{
    /// <summary>
    /// Naive Singleton : No thread safety
    /// </summary>
    public sealed class NaiveSingleton
    {
        // Private constructor
        private NaiveSingleton() { }

        private static NaiveSingleton _instance = null;
        // Property to access the Instance
        public static NaiveSingleton Instance
        {
            get
            {
                // Check if the Instance already exists
                if (_instance == null)
                {
                    _instance = new NaiveSingleton();
                }
                return _instance;
            }
        }
    }
}
