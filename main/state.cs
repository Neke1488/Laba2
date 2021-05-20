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

        private string name;
        private int population;
        private int territory;

        public State(string name, int population, int territory)
        {
            Name = name;
            Population = population;
            Territory = territory;
        }

        public string Name
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
            return $"Название страны: {Name} / Население: {Population} / Территория: {Territory} / Дата основания: {DateOfFoundation}";
        }

       
    }
}