using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10_CountryMVC
{
    internal class CountryController
    {
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("USA", "North America", new List<string>
            {
                "Red", "White", "Blue"
            }),

            new Country("Japan", "Asia", new List<string>
            {
                "Red", "White"
            }),

            new Country("Sri Lanka", "Asia", new List<string>
            {
                "Red", "Green", "Orange", "Yellow"
            }),

            new Country("Switzerland", "Europe", new List<string>
            {
                "Red", "White"
            }),

            new Country("El Salvador", "South America", new List<string>
            {
                "Blue", "White"
            })
        };

        public void CountryAction(Country c)
        {
            CountryView country = new CountryView(c);
            country.display();
        } 

        public void WelcomeAction()
        {
            bool runLoop = true;
            while (runLoop)
            {
                CountryListView c = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
                c.Display();
                int choice = Validator.Validator.GetInt();
                CountryAction(CountryDb[choice - 1]);
                runLoop = Validator.Validator.GetContinue();
            }
        }




    }
}
