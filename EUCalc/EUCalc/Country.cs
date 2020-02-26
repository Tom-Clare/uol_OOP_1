using System;
using System.Linq;

namespace EUCalc
{
    class Country
    {

        private string _code { get; set; }
        private string _name { get; set; }
        private int _population { get; set; }
        private bool _eurozone { get; set; }
        private int _vote { get; set; }
        private float _pop_percent { get; set; }
        public bool _partaking { get; set; }

        // Constructor increments total count of countries
        public Country(string code, string name, int pop, bool eurozone)
        {
            this._code = code;
            this._name = name;
            this._population = pop;
            this._eurozone = eurozone;

            // 0: not participating
            // 1: yes
            // 2: no
            // 3: abstain
            this._vote = 1; // default to yes
        }

        public override string ToString() //for debug
        {
            // simple message for debugging
            return this._code + " " + this._name + " " + this._population + " " + this._eurozone;
        }

        public string ToString(int name_pad_length, int pop_pad_length) //for display
        {
            string name_pad = getPadding(this._name, name_pad_length); // Get spaces for padding
            string pop_pad = getPadding(this._population.ToString(), pop_pad_length);

            // display token if in eurozone
            string eurozone_display = this._eurozone ? "   =+=  " : "        ";

            // return table line with separators and padding
            return this._code + "  | " + this._name + name_pad + "| "  + this._population + pop_pad + "| " + eurozone_display;
        }

        private string getPadding(string padding_subject, int padding_length)
        {
            int subject_length = padding_subject.Length;
            padding_length = padding_length - subject_length;

            // Multiply " " by the amount of padding needed to get target cell length
            string spaces = String.Concat(Enumerable.Repeat(" ", padding_length)); 

            return spaces;
        }
    }
}