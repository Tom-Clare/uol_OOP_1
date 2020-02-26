using System;
using System.Linq;
using System.Collections.Generic;

namespace EUCalc
{
    class Country
    {

        private string _code { get; set; }
        private string _name { get; set; }
        public int population { get; set; }
        public bool eurozone { get; set; }
        public int vote { get; set; }
        public static List<string> all_country_codes = new List<string>();

        public static Dictionary<int, string> vote_dict = new Dictionary<int, string>()
        {
            {0, "absent" },
            {1, "yes" },
            {2, "no" },
            {3, "abstain" }
        };

        // Constructor increments total count of countries
        public Country(string code, string name, int pop, bool eurozone)
        {
            this._code = code;
            this._name = name;
            this.population = pop;
            this.eurozone = eurozone;

            // 0: not participating
            // 1: yes
            // 2: no
            // 3: abstain
            this.vote = 1; // default to yes
        }

        public override string ToString() //for debug
        {
            // simple message for debugging
            return this._code + " " + this._name + " " + this.population + " " + this.eurozone;
        }

        public string ToString(int name_pad_length, int pop_pad_length, int vote_pad_length) //for display
        {
            decimal population_percentage = ((decimal)this.population / (decimal)Calculations.total_pop) * 100m;
            population_percentage = Math.Round(population_percentage, 2);

            string name_pad = getPadding(this._name, name_pad_length); // Get spaces for padding
            string name = this._name + name_pad;

            string pop_pad = getPadding(population_percentage.ToString(), pop_pad_length);
            string population = pop_pad + population_percentage.ToString() + "%   ";

            // display token if in eurozone
            string eurozone_display = this.eurozone ? "   =+=  " : "        ";

            string vote = vote_dict[this.vote];
            string vote_pad = getPadding(vote, vote_pad_length);
            vote = "  " + vote_pad + vote;


            // return table line with separators and padding
            return this._code + "  | " + name + "| "  + population + "| " + eurozone_display + " |" + vote;
        }

        private static string getPadding(string padding_subject, int padding_length)
        {
            int subject_length = padding_subject.Length;
            padding_length = padding_length - subject_length;

            // Multiply " " by the amount of padding needed to get target cell length
            string spaces = String.Concat(Enumerable.Repeat(" ", padding_length)); 

            return spaces;
        }

        public static bool setVote (List<Country> countries, string target)
        {
            for (int i = 0; i < countries.Count; i++)
            {
                if (target == "euro")
                {
                    if (countries[i].eurozone == false)
                    {
                        countries[i].vote = 0;  // no longer participating
                    }
                    else if (countries[i].vote == 0) // if not currently participating
                    {
                        countries[i].vote = 1;  // so if they are already participating, don't change their vote
                    }
                }
                else if (target == "all")
                {
                    countries[i].vote = 1;
                }
                else if (target == "none")
                {
                    countries[i].vote = 0;
                }
                else
                {
                    return false;  // failure, invalid target
                }
            }
            return true;  // success, executed with valid target
        }
        
        public static bool setVote(List<Country> countries, string country_code, int new_vote)
        {
            bool found = false;
            for (int i = 0; i < countries.Count; i++)
            {
                if (countries[i]._code == country_code)
                {
                    countries[i].vote = new_vote;
                    found = true;  // success, target found
                }
            }

            return found;
        }
    }
}