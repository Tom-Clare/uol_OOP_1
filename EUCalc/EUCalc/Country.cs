using System;

namespace VotingUI
{
    class Country
    {
        static int count
        {
            get { return count; }
            set { updatePopPercent(); }
        }

        private string _code { get; set; }
        private string _name { get; set; }
        private int _population { get; set; }
        private bool _eurozone { get; set; }
        private int _vote { get; set; }
        private string _flag_loc { get; set; }
        private float _pop_percent { get; set; }
        public bool _partaking { get; set; }

        // Constructor increments total count of countries
        public Country(string code, string name, int pop, bool eurozone, string flag_loc)
        {
            Country.count++;
            this._code = code;
            this._name = name;
            this._population = pop;
            this._eurozone = eurozone;
            this._flag_loc = flag_loc;

            // need to find a way to update a property when a static property is updated
        }
        static Country()
        {
            Country.count = 0;
        }
        // Finaliser decrements total count of countries
        ~Country()
        {
            Country.count--;
        }

        static void updatePopPercent()
        {
            
        }
    }
}