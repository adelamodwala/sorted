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

using System;
using System.Linq;

namespace Sorted.com.sorted.utils
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
            // Create a copy of the list
            int size = lst.Length;
            T[] result = new T[size];
            Array.Copy(lst, result, size);

            // Perform the sorting algorithm
            this.PerformSort<T>(result);
            return result;
        }

        /// <summary>Implement the sort functionality for sorter.</summary>
        /// 
        /// <param name="T">the generic type that is IComparable.</param>
        /// <param name="lst">an array to be sorted.</param>
        /// 
        /// <returns>a sorted copy of array lst.</returns>
        /// 
        protected abstract void PerformSort<T>(T[] lst) where T: System.IComparable;

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

        /// <summary>Swap two elements in an array.</summary>
        /// 
        /// <param name="T">the generic type that is IComparable.</param>
        /// <param name="lst">an array of type T.</param>
        /// 
        protected virtual void Swap<T>(T[] lst, int a, int b)
        {
            T temp = lst[a];
            lst[a] = lst[b];
            lst[b] = temp;
        }

    }
}