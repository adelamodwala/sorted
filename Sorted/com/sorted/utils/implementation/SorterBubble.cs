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
using Sorted.com.sorted.utils;

namespace Sorted.com.sorted.utils.implementation
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
        protected override void PerformSort<T>(T[] lst)
        {
            int size = lst.Length;

            for (int n = size; n > 0; n--)
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    if (lst[i - 1].CompareTo(lst[i]) > 0)
                    {
                        this.Swap<T>(lst, i - 1, i);
                    } // end if
                } // end for : i
            } // end for : n

        }
    }
}