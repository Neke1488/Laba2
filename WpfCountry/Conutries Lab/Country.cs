using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    //
    public class State
    {
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

        private string name;
        private int population;
        private int territory;

        public State()
        {
            this.Name = name;
            this.Population = population;
            this.Territory = territory;
          
        }


    }
}