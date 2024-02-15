using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10_CountryMVC
{
    internal class CountryView
    {
        public Country DisplayCountry {  get; set; }

        public CountryView(Country _displaycountry)
        {
            DisplayCountry = _displaycountry;
        }

        public void display()
        {
            Console.Write($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nColors: ");
            foreach(string s in DisplayCountry.Colors)
            {
                Console.Write(s + " ");
            }
        }
    }
}
