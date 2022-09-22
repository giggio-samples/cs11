#if NET7_0_OR_GREATER
using System.Numerics;
#else
using System.Runtime.Versioning;
#endif

namespace CSharp11;

#if NET6_0
[RequiresPreviewFeatures]
#endif
public class GenericMath
{
    public static T Sum<T>(params T[] values) where T : INumber<T>
    {
        T result = T.Zero; // static abstract interface method
        foreach (var value in values)
            result += value; // static abstract interface operator
        return result;
    }
}
