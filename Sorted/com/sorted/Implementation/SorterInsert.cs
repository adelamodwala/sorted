///***************************************************************************
/// 
/// Package:        Sorted.com.sorted.Implementation
/// Class:          SorterInsert
/// 
/// Project Name:   Sorted
/// 
/// Description:
/// 
/// An implementation of the Insertion Sort algorithm
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
    /// <summary>An insertion sorter.</summary>
    public class SorterInsert : SorterAbstract
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

            for (int i = 1; i < size; i++)
            {
                int j = i;
                while(j > 0 && result[j - 1].CompareTo(result[j]) > 0){
                    T temp = result[j - 1];
                    result[j - 1] = result[j];
                    result[j] = temp;
                    j--;
                } // end while
            }// end for

            return result;
        }

    }
}