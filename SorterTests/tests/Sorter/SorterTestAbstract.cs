using System;
using Sorted.com.sorted.utils;

namespace SorterTests.tests.Sorter
{
    public class SorterTestAbstract
    {
        protected ISorter TestSorter;

        public SorterTestAbstract(ISorter sorter)
        {
            this.TestSorter = sorter;
        }

        public virtual void RunBaseTests()
        {
            Console.WriteLine("**************{0}**************", TestSorter.GetType().Name);
            AssertSortEmpty<int>();
            AssertMinMaxEmpty<int>();

            AssertSortSingle<int>(new int[] {54});
            AssertSortSingle<string>(new string[] { "bob" });

            AssertSortSimple<int>(new int[] {26, 32, 12, 195, 7});
            AssertSortSimple<string>(new string[] { "Rob", "Pearl", "Crystal", "Amethyst", "Steven", "Garnet" });
            AssertSortSimple<double>(new double[] { 26, 32.41, 123.67, 19.5, 7 });
            AssertSortSimple<decimal>(new decimal[] { 26m, 32.41m, 123.67m, 19.5m, 7m });
        }

        // Assert sorter behaves correctly with empty array
        public virtual void AssertSortEmpty<T>() where T : System.IComparable
        {
            T[] empty = new T[0];
            T[] result = TestSorter.Sort<T>(empty);

            // Empty array is returned
            Console.WriteLine("Empty array gets sorted: {0}", result.Length == 0);
            Console.WriteLine(string.Join(",", result));
        }

        // Assert sorter minimum/maximum finder behaves correctly with empty array
        public virtual void AssertMinMaxEmpty<T>() where T : System.IComparable
        {
            T[] empty = new T[0];
            // 0 is returned for Max and Min
            Console.WriteLine("Min: {0}, Max: {1}", TestSorter.FindMax<T>(empty), TestSorter.FindMin<T>(empty));
        }


        public virtual void AssertSortSingle<T>(T[] lst) where T : System.IComparable
        {

            T[] result = TestSorter.Sort<T>(lst);

            Console.WriteLine("====================");
            Console.WriteLine("Array with one element gets sorted: {0}", result.Length == 1);
            Console.WriteLine(string.Join(",", result));
            Console.WriteLine("====================");
        }

        public virtual void AssertSortSimple<T>(T[] lst) where T: System.IComparable
        {
            T[] result = TestSorter.Sort<T>(lst);
            T[] defaultResult = new T[lst.Length];
            Array.Copy(lst, defaultResult, lst.Length);
            Array.Sort(defaultResult);

            Console.WriteLine("====================");
            Console.WriteLine("Array with multiple elements gets sorted: {0}\nDefault: {1}\nSorter : {2}", string.Join(",", result) == string.Join(",", defaultResult), string.Join(",", defaultResult), string.Join(",", result));
            Console.WriteLine("====================");
        }
    }
}
