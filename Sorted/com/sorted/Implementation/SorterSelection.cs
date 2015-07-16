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
        protected override T[] PerformSort<T>(T[] lst)
        {
            int size = lst.Length;
            T[] result = new T[size];
            Array.Copy(lst, result, size);

            for (int i = 0; i < size; i++)
            {
                int jMin = i;
                for (int j = i + 1; j < size; j++ )
                {
                    if (result[j].CompareTo(result[jMin]) < 0)
                    {
                        jMin = j;
                    }
                } // end for : j

                if (jMin != i)
                {
                    T temp = result[i];
                    result[i] = result[jMin];
                    result[jMin] = temp;
                } // end if
            } // end for : i

            return result;
        }

    }
}