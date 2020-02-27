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
        public static Dictionary<string, int[]> rule_dict = new Dictionary<string, int[]>()
        {
            {"qm", new int[] {55, 65} },
            {"rqm", new int[] {72, 65} },
            {"sm", new int[] {50} },
            {"u", new int[] {100} },
        };

        public static bool getResult(List<Country> countries)
        {
            bool outcome = true;
            national_result = calcMemState(countries);
            population_result = calcPop(countries);
            if ((((rule_dict[voting_rule].Length == 2)) && (population_result < rule_dict[voting_rule][1]) || ((rule_dict[voting_rule].Length != 2) && (national_result < rule_dict[voting_rule][0]))))
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
                if (countries[i].vote != 0)
                {
                    votes++;
                }
                if (countries[i].vote == 1)
                {
                    yes_votes++;
                }
            }

            if (votes == 0)
            {
                return 0m;
            }

            decimal percentage = ((decimal)yes_votes / (decimal)votes) * 100m;
            percentage = Math.Round(percentage, 2);
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

            if (total_population == 0)
            {
                return 0m;
            }

            total_pop = total_population;
            decimal percentage = ((decimal)yes_population / (decimal)total_population) * 100m;

            percentage = Math.Round(percentage, 2);
            return percentage;
        }


    }
}
