using System;
using System.Collections.Generic;

namespace VehicleRegistrationSystem
{
    [Serializable]
    class clsSortDate : IComparer<clsActivity>
    {
        public int Compare(clsActivity x, clsActivity y)
        {
            return x.HiringStartDate.CompareTo(y.HiringStartDate);
        }
    }
}
