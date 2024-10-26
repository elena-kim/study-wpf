namespace DesignPattern
{
    public sealed class DotNetLazy
    {
        private static readonly Lazy<DotNetLazy> lazy = new(() => new DotNetLazy());

        public static DotNetLazy Instance => lazy.Value;

        private DotNetLazy() { }
    }
}
