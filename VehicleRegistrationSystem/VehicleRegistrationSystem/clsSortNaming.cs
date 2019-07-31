using System.Collections.Generic;

namespace VehicleRegistrationSystem
{
    class clsSortNaming : IComparer<clsActivity>
    {
        public int Compare(clsActivity x, clsActivity y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
