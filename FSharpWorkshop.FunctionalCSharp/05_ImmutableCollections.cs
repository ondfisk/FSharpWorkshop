using System.Collections.Generic;
using System.Collections.Immutable;

namespace FSharpWorkshop.FunctionalCSharp
{
    public class ImmutableCollections
    {
        public static void Main2(string[] args)
        {
            var set = ImmutableHashSet<string>.Empty;

            var list = ImmutableList<int>.Empty;
            var newList = list.Add(5);

            ICollection<int> mutable = newList;
            mutable.Add(5);

            var map = ImmutableDictionary<double, string>.Empty;
        }
    }
}
