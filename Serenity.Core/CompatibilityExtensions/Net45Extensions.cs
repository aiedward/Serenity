#if !PORTABLE
namespace System
{
    public static class CompatibilityExtensions
    {
        public static bool GetIsEnum(this Type type)
        {
            return type.IsEnum;
        }

        public static bool ContainsGenericParameters(this Type type)
        {
            return type.ContainsGenericParameters;
        }

        public static bool GetIsGenericType(this Type type)
        {
            return type.IsGenericType;
        }

        public static bool GetIsAbstract(this Type type)
        {
            return type.IsAbstract;
        }

        public static bool GetIsClass(this Type type)
        {
            return type.IsClass;
        }

        public static bool GetIsInterface(this Type type)
        {
            return type.IsInterface;
        }

        public static bool GetIsGenericTypeDefinition(this Type type)
        {
            return type.IsGenericTypeDefinition;
        }

        public static bool GetContainsGenericParameters(this Type type)
        {
            return type.ContainsGenericParameters;
        }

        public static bool GetIsPrimitive(this Type type)
        {
            return type.IsPrimitive;
        }
    }
}
#endif