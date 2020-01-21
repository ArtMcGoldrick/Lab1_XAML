using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_XAML
{
    /*
2.	Create a class called Band with Band Name, Year formed and Members.
3.	Create 6 bands and display in the listbox
4.	Implement IComparable to enable sorting by Band Name
5.	Sort the bands
6.	Make Band an abstract class
7.	Create sub classes of Rock Band, Pop Band and Indie Band
8.	Override the ToString() method to display the type of band in the listbox.
9.	Create an album class, which should have Album Name, Released (a year), Sales.  Use random for year of release and sales.
10.	Clicking on a band name should display the Name, Year Formed and Members along with a list of the Albums
11.	Add filtering to filter by Genre
12.	Amend Released to a DateTime object and calculate years since release which should be displayed in the listbox.
13.	Add functionality to write the band information to file. 
     */
    class Band
    {
        //Properties
        public string name { get; set; }
        public int yearFormed { get; set; }
        public string members { get; set; }

        //Method with vague info
        public Band() : this("unknown", 0, "Unknown")
        {

        }

        //Method with real info
        public Band(string Name, int YearsFormed, string Members)
        {

        }
    }
}
