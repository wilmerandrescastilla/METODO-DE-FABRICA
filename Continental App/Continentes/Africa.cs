using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Continental_App.Animals;

namespace Continental_App.Continents
{
    class Africa : Continente
    {
        public override void CreateContinent()
        {
            Animals.Add(new Elefante());
            Animals.Add(new Leon());
            
        }
    }
}
