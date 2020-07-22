using System;
using System.Collections.Generic;
using System.Text;

namespace Meus_Snippets
{
    public static class DistinctByClass
    {
       
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
        (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

//        So to find the distinct values using just the Id property, you could use:
//        var query = people.DistinctBy(p => p.Id);
    }
}
