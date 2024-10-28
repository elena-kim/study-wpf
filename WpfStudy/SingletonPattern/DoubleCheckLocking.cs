namespace SingletonPattern
{
    public sealed class DoubleCheckLocking
    {
        private static object _lockObj = new object();

        // Private Constructor
        private DoubleCheckLocking() { }

        private static DoubleCheckLocking _instance = null;
        // Property to access the Instance
        public static DoubleCheckLocking Instance
        {
            get
            {
                // First check
                if (_instance == null)
                {
                    // Locking the lockObj
                    lock (_lockObj)
                    {
                        if (_instance == null)
                            _instance = new DoubleCheckLocking();
                    }
                }

                return _instance;
            }
        }
    }
}
