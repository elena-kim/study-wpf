using System.Reflection;

namespace DeconstructingTuples
{
    public static class ReflectionExtensions
    {
        public static void Deconstruct(this PropertyInfo p, out bool isStatic,
                                   out bool isReadOnly, out bool isIndexed,
                                   out Type propertyType)
        {
            var getter = p.GetMethod;

            // Is the property read-only?
            isReadOnly = !p.CanWrite;

            // Is the property instance or static?
            isStatic = getter.IsStatic;

            // Is the property indexed?
            isIndexed = p.GetIndexParameters().Length > 0;

            // Get the property type.
            propertyType = p.PropertyType;
        }
    }
}
