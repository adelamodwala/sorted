using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sorted.com.sorted.utils.sorters;
using Sorted.com.sorted.dao;

namespace Sorted.com.sorted.service.implementation
{
    public class SorterServiceImpl : AbstractServiceImpl, ISorterService
    {
        // The Sorter DAO
        protected ISorterDAO sorterDAO;

        /// <summary>Answer the IReferenceValueService Service</summary>
        public ISorterDAO getSorterDAO()
        {
            return this.sorterDAO;
        }

        /// <summary> Retrieve all available Sorters.</summary>
        public ISorter[] getSorters()
        {
            return this.getSorterDAO().getSorters();
        }
    }
}