using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Liebre:Corredor //clase a heredar
    {
        /// <summary>
        /// se tiene que hacer el constructor para que sepa el valor que debe heredar
        /// </summary>
        /// <param name="numero"></param>
        public Liebre(int numero): base(numero){}

        new public  int correr()
        {
            int avance = base.correr();
            if (avance <= 4)
                return _posicion;
            else if (avance <= 8)
                return _posicion += 12;
            else if (avance <= 13)
                return _posicion += 5;
            else if (avance <= 16)
                return _posicion -= 4;
            else
                return _posicion -= 9;
        }

    }
}
