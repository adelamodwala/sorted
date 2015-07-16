///***************************************************************************
/// 
/// Package:        Sorted.com.sorted.Implementation
/// Class:          SorterAbstract
/// 
/// Project Name:   Sorted
/// 
/// Description:
/// 
/// This abstract Sorter class defines a number of common methods
/// for all Sorter objects.
/// 
/// @author:      <author>Adel Amodwala</author>
/// @created:     July 12, 2015
/// 
/// 
/// ***************************************************************************
/// 

using System.Linq;

namespace Sorted.com.sorted.Implementation
{
    /// <summary>An abstract sorter class that defines a common set of functionality for sorter objects.</summary>
    public abstract class SorterAbstract : ISorter
    {

        /// <summary>Copy and sort an array of items.</summary>
        /// 
        /// <param name="T">the generic type that is IComparable.</param>
        /// <param name="lst">an array to be sorted.</param>
        /// 
        /// <returns>a sorted copy of array lst.</returns>
        /// 
        public virtual T[] Sort<T>(T[] lst) where T : System.IComparable
        {
            T[] sorted = PerformSort<T>(lst);
            return sorted;
        }

        /// <summary>Implement the sort functionality for sorter.</summary>
        /// 
        /// <param name="T">the generic type that is IComparable.</param>
        /// <param name="lst">an array to be sorted.</param>
        /// 
        /// <returns>a sorted copy of array lst.</returns>
        /// 
        protected abstract T[] PerformSort<T>(T[] lst) where T: System.IComparable;

        /// <summary>Find the minimum from an array using implemented sort technique.</summary>
        /// 
        /// <param name="T">the generic type that is IComparable.</param>
        /// <param name="lst">an array to find minimum from.</param>
        /// 
        /// <returns>the minimum/smallest value of this array.</returns>
        /// 
        public virtual T FindMin<T>(T[] lst) where T : System.IComparable
        {
            T[] result = Sort<T>(lst);
            return result.FirstOrDefault();
        }

        /// <summary>Find the maximum from an array using implemented sort technique.</summary>
        /// 
        /// <param name="T">the generic type that is IComparable.</param>
        /// <param name="lst">an array to find maximum from.</param>
        /// 
        /// <returns>the maximum/largest value of this array.</returns>
        /// 
        public virtual T FindMax<T>(T[] lst) where T : System.IComparable
        {
            T[] result = Sort<T>(lst);
            return result.LastOrDefault();
        }

    }
}