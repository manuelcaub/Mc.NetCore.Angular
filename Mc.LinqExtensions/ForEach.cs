namespace System.Linq
{
    using System;
    using System.Collections.Generic;

    public static partial class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> elements, Action<T> action)
        {
            foreach (var element in elements)
            {
                action(element);
            }
        }
    }
}
