namespace SingletonPattern
{
    public sealed class SimpleThreadSafe
    {
        private static object _lockObj = new object();

        // Private Constructor
        private SimpleThreadSafe() { }

        private static SimpleThreadSafe _instance = null;
        // Property to access the Instance
        public static SimpleThreadSafe Instance
        {
            get
            {
                // locking the shared object
                lock (_lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new SimpleThreadSafe();
                    }

                    return _instance;
                }
            }
        }
    }
}