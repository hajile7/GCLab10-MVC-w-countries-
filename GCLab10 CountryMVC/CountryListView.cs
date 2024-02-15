using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GCLab10_CountryMVC
{
    internal class CountryListView
    {
        public List<Country> Countries = new List<Country>();

        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }

        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine((i + 1) + $". {Countries[i].Name}");
            }
        }
    }
}
