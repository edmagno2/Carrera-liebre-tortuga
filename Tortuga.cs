using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Tortuga:Corredor //indicamos que hereda de clase corredor 
    {
        public Tortuga(int numero) : base(numero){}
        new public int correr()
        {
            int avance = base.correr();
            if (avance <= 8)
                return _posicion += 4;
            else if (avance <= 12)
                return _posicion += 6;
            else if (avance <= 16)
                return _posicion -= 5;
            else if (avance <= 20)
                return _posicion -= 8;
            return 0;
        }
    }
}
