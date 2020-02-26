using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUCalc
{
    class Calculations
    {
        public static string voting_rule { get; set; }

        public static bool votePassed(float memeberState, float population, string votingRule)
        {
            // country overall vote
            // member state overall vote
            // these two along with the voting rule return true or false for approved or rejected
            return true;
        }

        public static float calcMemState(List<Country> countries)
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

            
            float percentage = (yes_votes / votes) * 100;
            return percentage;
        }

        public static decimal calcPop(List<Country> countries)
        {
            int totalpopulation = 0;
            int yes_population = 0;
            for (int i = 0; i < countries.Count; i++)
            {
                if (countries[i].vote != 0)
                {
                    totalpopulation = totalpopulation + countries[i].population;
                    if (countries[i].vote == 1)
                    {
                        yes_population = yes_population + countries[i].population;
                    }
                }

                
            }

            decimal temp = (decimal)yes_population / (decimal)totalpopulation;
            decimal percentage = ((decimal)yes_population / (decimal)totalpopulation) * 100m;

            percentage = Math.Round(percentage, 2);
            return percentage;

            // number that voted yes out the total number of population
            

        }


    }
}
