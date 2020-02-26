using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUCalc
{
    class Calculations
               
    {
        public string voting_rule { get; set; }

        public bool votePassed(float memeberState, float population, string votingRule)
        {
        // country overall vote
        // member state overall vote
        // these two along with the voting rule return true or false for approved or rejected
            return true;
        }

        public float calcMemState(List<Country> countries)
        {
            //number of votes for yes out of the number of those who voted
            int votes = 0;
            int yes_votes = 0;
            for (int i = 0; i < countries; i++)
            {
                votes++;
                if (countries[i]._vote == 1)
                {
                    yes_votes++;
                }
            }

            Console.WriteLine(votes);
            Console.WriteLine(yes_votes);
            return 1;
        }

        public float calcPop ()
        {


            // number that voted yes out the total number of population

        }


    }
}
