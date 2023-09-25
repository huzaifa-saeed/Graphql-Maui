using System.Collections;

namespace Graphql_Maui.Services;

public static class EnumerableExtensions
{
    public static bool IsEnumerableNullOrEmpty(this IEnumerable? enumerable) => enumerable is not null && !enumerable.GetEnumerator().MoveNext();
}