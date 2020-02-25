using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace EUCalc
{
    static class Program
    {
        
        static void Main(string[] args)
        {

            List<Country> countries = initCountries(); // Read config file and compile Country List
            displayStartMessage();
            displayCountriesTable(countries); // Dispay Table
            string input = "";
            
        }

        private static List<Country> initCountries()  // Create an iterable contries List
        {

            // open init file
            string config_file = "country_config.csv";
            StreamReader file = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\../../\" + config_file);

            List<Country> countries = new List<Country>();
            string line = "";
            bool eurozone = false;
            while ((line = file.ReadLine()) != null)  // For every line in the config file
            {
                string[] details = line.Split(',');
                eurozone = int.Parse(details[3]) != 0;  // If eurozone isn't 0, set to true
                countries.Add(new Country(details[0], details[1], int.Parse(details[2]), eurozone));  // Add country to List
            }

            return countries;
        }

        private static void displayStartMessage()
        {
            Console.WriteLine("Type h for help and exit to exit the application.");
        }

        private static void displayHelp ()
        {
            string help = @"
To change a country's vote, type the country code followed by the number or name of the new vote.
For example:
    DE 2
    EE non-participating
    CZ abstain

The available votes are as follows:
    0 non-partcipating
    1 yes
    2 no
    3 abstain

To change the voting rule, type rule followed by the code of the new voting rule.
For example:
    rule qm
    rule u

The available voting rules are as follows:
    qm Qualified Majority
    rqm Reinforced Qualified Majority
    sm Simple Majority
    u Unanimity
            ";
            Console.WriteLine(help);
        }

        // Creates table of countries and displays it to the console
        private static void displayCountriesTable (List<Country> countries)
        {
            Console.WriteLine(" ________________________________________________");
            Console.WriteLine("| Code | Country         | Population | Eurozone |");
            Console.WriteLine("|======|=================|============|==========|");

            // Iterate and display details
            for (int i = 0; i < countries.Count; i++)
            {
                Console.Write("|  ");
                Console.Write(countries[i].ToString(16, 11)); // Polymorphed ToString() method
                Console.Write(" |\n");
            }

            Console.WriteLine("|______|_________________|____________|__________|");
        }
    }
}
