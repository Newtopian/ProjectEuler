using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    // A set of integer generator extension methods
    //inspired (well copied more like) from
    //http://geekswithblogs.net/BlackRabbitCoder/archive/2010/04/21/more-fun-with-c-iterators-and-generators.aspx
    public static class IntExtensions
    {
        // Begins counting to inifity, use To() to range this.
        public static IEnumerable<int> Every(this int start)
        {
            // deliberately avoiding condition because keeps going
            // to infinity for as long as values are pulled.
            for (var i = start; ; ++i)
            {
                yield return i;
            }
        }

        // Begins counting to infinity by the given step value, use To() to
        public static IEnumerable<int> Every(this int start, int byEvery)
        {
            // deliberately avoiding condition because keeps going
            // to infinity for as long as values are pulled.
            for (var i = start; ; i += byEvery)
            {
                yield return i;
            }
        }

        // Begins counting to inifity, use To() to range this.
        public static IEnumerable<int> To(this int start, int end)
        {
            for (var i = start; i <= end; ++i)
            {
                yield return i;
            }
        }

        // Ranges the count by specifying the upper range of the count.
        public static IEnumerable<int> To(this IEnumerable<int> collection, int end)
        {
            return collection.TakeWhile(item => item <= end);
		}

		public static IEnumerable<int> Fibo(this IEnumerable<int> collection)
		{
			//if(collection.Count() < 2) throw new InvalidOperationException("cannot compute a fibonnaci sequence without 2 starting numbers in the array");

			yield return collection.Last() + collection.ElementAt(collection.Count() - 2);
		}
    }
}
