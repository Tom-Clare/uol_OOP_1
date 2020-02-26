using System;
using System.Collections.Generic;

namespace EUCalc
{
    class Calculations
    {
        public static string voting_rule { get; set; }
        public static decimal population_result { get; set; }
        public static decimal national_result { get; set; }
        public static int total_pop { get; set; }

        public static bool getResult(List<Country> countries)
        {
            bool outcome = true;
            population_result = calcMemState(countries);
            national_result = calcPop(countries);
            if ((voting_rule == "qm") && ((population_result < 65) || (national_result < 55)))
            {
                outcome = false;
            }
            else if ((voting_rule == "rqm") && ((population_result < 65) || (national_result < 72)))
            {
                outcome = false;
            }
            else if ((voting_rule == "sm") && (national_result < 50))
            {
                outcome = false;
            }
            else if ((voting_rule == "sm") && (national_result != 100))
            {
                outcome = false;
            }
            return outcome;
        }

        public static decimal calcMemState(List<Country> countries)
        {
            //number of votes for yes out of the number of those who voted
            int votes = 0;
            int yes_votes = 0;
            for (int i = 0; i < countries.Count; i++)
            {
                votes++;
                if (countries[i].vote == 1)
                {
                    yes_votes++;
                }
            }

            
            decimal percentage = (yes_votes / votes) * 100;
            return percentage;
        }

        public static decimal calcPop(List<Country> countries)
        {
            int total_population = 0;
            int yes_population = 0;
            for (int i = 0; i < countries.Count; i++)
            {
                if (countries[i].vote != 0)
                {
                    total_population = total_population + countries[i].population;
                    if (countries[i].vote == 1)
                    {
                        yes_population = yes_population + countries[i].population;
                    }
                }

                
            }

            total_pop = total_population;
            decimal percentage = ((decimal)yes_population / (decimal)total_population) * 100m;

            percentage = Math.Round(percentage, 2);
            return percentage;
        }


    }
}
