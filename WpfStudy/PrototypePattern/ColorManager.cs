namespace PrototypePattern
{
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors = [];

        // Indexer
        public ColorPrototype this[string key]
        {
            get => colors[key];
            set => colors.Add(key, value);
        }
    }
}
