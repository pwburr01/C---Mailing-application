//C7353
//Program 4
//11-27-2017
//CIS200-01
//This class is the comparer class. It will override the generic sort with a sort of its own designed to display by zip codes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ComparerClass : Comparer<Parcel>
    {
        //precondition: none
        //postcondition: parcels are compared to each other
        public override int Compare(Parcel parcel1, Parcel parcel2)
        {
            //if statements deciding which position to place the parcels
            if (parcel1.DestinationAddress.Zip.ToString() == null && parcel2.DestinationAddress.Zip.ToString() == null)
                return 0;

            if (parcel1.DestinationAddress.Zip.ToString() == null)
                return -1;

            if (parcel2.DestinationAddress.Zip.ToString() == null)
                return 1;

            return (-1) * parcel1.DestinationAddress.Zip.ToString().CompareTo(parcel2.DestinationAddress.Zip.ToString());

        }
    }
}
