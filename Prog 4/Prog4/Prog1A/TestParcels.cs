//C7353
//Program 4
//11-27-2017
//CIS200-01


// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.
//It also uses Icomparer and sort to determine the way in which each one will be displayed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a3, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            Letter letter2 = new Letter(a4, a3, 3.22M);                            // Letter test object
            GroundPackage gp2 = new GroundPackage(a3, a2, 10, 12, 4, 22.5);        // Ground test object
            NextDayAirPackage ndap2 = new NextDayAirPackage(a1, a4, 15, 5, 5,    // Next Day test object
                85, 7.90M);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a2, a4, 50.5, 42.5, 22.0, // Two Day test object
                90.5, TwoDayAirPackage.Delivery.Saver);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a1, a3
                , 15, 5, 5,    // Next Day test object
              85, 7.90M);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a2, a3, 50.5, 42.5, 22.0, // Two Day test object
                90.5, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(letter2); 
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);
            parcels.Add(ndap3);
            parcels.Add(tdap3);

            //displays list
            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            //displays list in the general sort that is of the calcCost method 
            parcels.Sort();
            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            //displays list in the comparerclasses override of the zipcode method and bases it upon zip code in descending order
            parcels.Sort(new ComparerClass());
            Console.WriteLine("Sorted List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
