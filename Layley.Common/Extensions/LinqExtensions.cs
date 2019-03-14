using System.Collections.Generic;
using System.Linq;

namespace Layley.Common.Extensions
{
    public static class LinqExtensions
    {
        /// <summary>
        /// Determines if an enumerable is null or contains no values
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) =>
            source == null
                ? true
                : !source.Any();
    }
}
