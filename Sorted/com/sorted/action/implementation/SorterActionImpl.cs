using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sorted.com.sorted.utils.sorters;
using Sorted.com.sorted.service;

namespace Sorted.com.sorted.action.implementation
{
    public class SorterActionImpl : AbstractActionImpl, ISorterAction
    {
        // The Sorter Service
        protected ISorterService sorterService;

        /// <summary>Answer the IReferenceValueService Service</summary>
        public ISorterService getSorterService()
        {
            return this.sorterService;
        }

        /// <summary> Retrieve all available Sorters.</summary>
        public ISorter[] getSorters()
        {
            return this.getSorterService().getSorters();
        }
    }
}