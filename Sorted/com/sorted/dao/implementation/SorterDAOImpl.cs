using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sorted.com.sorted.utils.sorters;

namespace Sorted.com.sorted.dao.implementation
{
    public class SorterDAOImpl : AbstractSorterDAOImpl, ISorterDAO
    {
        /// <summary> All available sorters
        ISorter[] availableSorters;

        /// <summary> Get all available sorters
        ISorter[] getAvailableSorters()
        {
            return this.availableSorters;
        }

        /// <summary> Retrieve all Sorters.</summary>
        public ISorter[] getSorters()
        {
            return this.getAvailableSorters();
        }
    }
}