using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sorted.com.sorted.utils.sorters;

namespace Sorted.com.sorted.action
{
    public interface ISorterAction
    {
        /// <summary> Retrieve all available Sorters.</summary>
        ISorter[] getSorters();

    }
}