using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    [Serializable]
    public class Republic : State
    {
        public readonly string type = "Республика";

        private string _Language;
        private string _DateOfFoundation;
        private string _PowerOfCountry;

        public Republic(string name, int population, int territory, string _DateOfFoundation, string _PowerOfCountry, string _Language)
        {
            this.Name = name;
            this.Population = population;
            this.Territory = territory;
            this.DateOfFoundation = _DateOfFoundation;
            this.PowerOfCountry = _PowerOfCountry;
            this.Language = _Language;
        }

        public Republic() { }

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
            set { _Language = value; }
        }


        public override string ToString()
        {
            return ($"Название страны: {Name} / Население: {Population} / Территория: {Territory} / Дата основания: {_DateOfFoundation} / Власть страны: {_PowerOfCountry} / Язык страны: {_Language}");
        }

        public bool IsSearch(string searchText) => 
            Name.ToUpper().Contains(searchText.ToUpper()) || 
            Population.ToString().ToUpper().Contains(searchText.ToUpper()) || 
            Territory.ToString().ToUpper().Contains(searchText.ToUpper()); 
    }
}