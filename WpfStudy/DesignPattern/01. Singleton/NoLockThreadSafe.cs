namespace DesignPattern
{
    public sealed class NoLockThreadSafe
    {
        private static NoLockThreadSafe _instance = new NoLockThreadSafe();

        // Explicit static constructor to force the C#
        // compiler not to mark the type as before field init
        static NoLockThreadSafe() 
        {
        
        }

        private NoLockThreadSafe() { }

        public static NoLockThreadSafe Instance
        {
            get { return _instance; }
        }
    }
}
