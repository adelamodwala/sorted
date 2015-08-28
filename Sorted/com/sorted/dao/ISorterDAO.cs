using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sorted.com.sorted.utils.sorters;

namespace Sorted.com.sorted.dao
{
    public interface ISorterDAO
    {
        /// <summary> Retrieve all available Sorters.</summary>
        ISorter[] getSorters();
    }
}