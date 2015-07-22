// An interface for Sorter classes

namespace Sorted.com.sorted.utils
{
    public interface ISorter
    {
        // Return a sorted object T
        // <param name="lst"
        //        type="generic list T" />
        T[] Sort<T>(T[] lst) where T : System.IComparable;

        // Return the minimum value using
        // sort implementation
        // <param name="lst"
        //        type="generic list T" />
        T FindMin<T>(T[] lst) where T : System.IComparable;

        // Return the maximum value using
        // sort implementation
        // <param name="lst"
        //        type="generic list T" />
        T FindMax<T>(T[] lst) where T : System.IComparable;
        
    }
}
