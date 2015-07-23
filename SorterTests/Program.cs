using System;
using SorterTests.tests.Sorter;
using Sorted.com.sorted.utils;
using Sorted.com.sorted.utils.sorters;

namespace SorterTests
{
    class Program
    {
        static void Main(string[] args)
        {
            SorterBubble bubbleSorter = new SorterBubble();
            ISorter sorter = (ISorter)bubbleSorter;
            SorterTestBubble bubble = new SorterTestBubble(sorter);
            bubble.RunBaseTests();

            SorterInsert insertSorter = new SorterInsert();
            ISorter sorter1 = (ISorter)insertSorter;
            SorterTestAbstract insert = new SorterTestAbstract(sorter1);
            insert.RunBaseTests();

            SorterSelection selectionSorter = new SorterSelection();
            ISorter sorter2 = (ISorter)selectionSorter;
            SorterTestAbstract selection = new SorterTestAbstract(sorter2);
            selection.RunBaseTests();

            Console.ReadLine();
        }
    }
}
