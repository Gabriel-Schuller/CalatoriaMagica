using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalatoriaMagica.Obiecte
{
    public class ArticolInventar
    {
        public float Greutate { get; }
        public float Volum { get; }
        public ArticolInventar(float greutate, float volum)
        {
            Greutate = greutate;
            Volum = volum;
        }
    }
}
