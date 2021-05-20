using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    class State : Country
    {
        public readonly string type = "Штат";

        private string _Language;
        private string _DateOfFoundation;
        private string _PowerOfCountry;
        public State(string name, int population, int territory, string _DateOfFoundation, string _PowerOfCountry, string _Language)
        {
            NameCountry = name;
            Population = population;
            Territory = territory;
            DateOfFoundation = _DateOfFoundation;
            PowerOfCountry = _PowerOfCountry;
            Language = _Language;
        }

       

        public string DateOfFoundation
        {
            get { return _DateOfFoundation; }
            set { _DateOfFoundation = value; }
        }

        public string PowerOfCountry
        {
            get { return _PowerOfCountry; }
            set { _PowerOfCountry = value; }
        }

        public string Language
        {
            get { return _Language; }
            set { _PowerOfCountry = value; }
        }


        public override string ToString()
        {
            return ($"Название страны: {NameCountry} / Население: {Population} / Территория: {Territory} / Дата основания: {_DateOfFoundation} / Власть страны: {_PowerOfCountry} / Язык страны: {_Language}");
        }

       
    }
}