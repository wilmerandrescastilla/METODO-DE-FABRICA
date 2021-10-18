using Continental_App.Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continental_App.Continentes
{
    class America: Continente
    {


        public override void CreateContinent()
        {
            Animals.Add(new Pinguino());
            Animals.Add(new Venado());
        }

    }
}
