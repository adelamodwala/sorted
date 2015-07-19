///***************************************************************************
/// 
/// Package:        Sorted.com.sorted.Implementation
/// Class:          SorterSelection
/// 
/// Project Name:   Sorted
/// 
/// Description:
/// 
/// An implementation of the Slection Sort algorithm
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
    /// <summary>An selection sorter.</summary>
    public class SorterSelection : SorterAbstract
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

            for (int i = 0; i < size; i++)
            {
                int jMin = i;
                for (int j = i + 1; j < size; j++ )
                {
                    if (lst[j].CompareTo(lst[jMin]) < 0)
                    {
                        jMin = j;
                    }
                } // end for : j

                if (jMin != i)
                {
                    this.Swap(lst, i, jMin);
                } // end if
            } // end for : i
        }

    }
}