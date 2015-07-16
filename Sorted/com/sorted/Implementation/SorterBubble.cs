///***************************************************************************
/// 
/// Package:        Sorted.com.sorted.Implementation
/// Class:          SorterBubble
/// 
/// Project Name:   Sorted
/// 
/// Description:
/// 
/// An implementation of the Bubble Sort algorithm
/// inherited from the SorterAbstract class
/// 
/// @author:      <author>Adel Amodwala</author>
/// @created:     July 12, 2015
/// 
/// 
/// ***************************************************************************
/// 

using System;
using System.Linq;
using Sorted.com.sorted;

namespace Sorted.com.sorted.Implementation
{
    /// <summary>A bubble sorter.</summary>
    public class SorterBubble : SorterAbstract
    {

        /// <summary>Implement the sort functionality for sorter.</summary>
        /// 
        /// <param name="T">the generic type that is IComparable.</param>
        /// <param name="lst">an array to be sorted.</param>
        /// 
        /// <returns>a sorted copy of array lst.</returns>
        /// 
        protected override T[] PerformSort<T>(T[] lst)
        {
            int size = lst.Length;
            T[] result = new T[size];
            Array.Copy(lst, result, size);

            for (int n = size; n > 0; n--)
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    if (result[i - 1].CompareTo(result[i]) > 0)
                    {
                        T temp = result[i - 1];
                        result[i - 1] = result[i];
                        result[i] = temp;
                    } // end if
                } // end for : i
            } // end for : n

            return result;
        }
    }
}