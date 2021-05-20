using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    class Kingdom : Country
    {
        public readonly string type = "Королевство";

        private string name;
        private int population;
        private int territory;

        public Kingdom(string name, int population, int territory)
        {
            NameCountry = name;
            Population = population;
            Territory = territory;
        }

        public string NameCountry
        {
            get { return name; }
            set { name = value; }
        }

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public int Territory
        {
            get { return territory; }
            set { territory = value; }
        }

        public int DateOfFoundation
        {
            get { return DateOfFoundation; }
            set { DateOfFoundation = value; }
        }

        public override string ToString()
        {
            return ($"Название страны: {NameCountry} / Население: {Population} / Территория: {Territory} / Дата основания: {DateOfFoundation}");
        }

        
    }
}