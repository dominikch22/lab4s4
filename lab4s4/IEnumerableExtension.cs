using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4s4
{
    public static class IEnumerableExtension
    {
        public static T MostCommonElement<T>(this IEnumerable<T> input) {
      
            var mostCommonElement = input.GroupBy(item => item)
                                      .OrderByDescending(group => group.Count())
                                      .Select(group => group.Key)
                                      .First();

            return mostCommonElement;
        }
    }
}
