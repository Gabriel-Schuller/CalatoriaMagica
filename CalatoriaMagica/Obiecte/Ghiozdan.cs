using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalatoriaMagica.Obiecte
{
    public class Ghiozdan
    {
        public List<ArticolInventar> Articole { get; }
        public int NumarMaxim { get; }
        public float GreutateMaxima { get; }
        public float VolumMaxim { get; }
        public int NumarCurent { get; private set; }
        public float GreutateCurenta { get; private set; }
        public float VolumCurent { get; private set; }


        public Ghiozdan(int numarMaxim, float greutateMaxima, float volumMaxim)
        {
            NumarMaxim = numarMaxim;
            GreutateMaxima = greutateMaxima;
            VolumMaxim = volumMaxim;
            Articole = new List<ArticolInventar>();
            NumarCurent = 0;
            GreutateCurenta = 0f;
            VolumCurent = 0f;
        }

        public bool Adauga(ArticolInventar articol)
        {
            if (NumarMaxim == NumarCurent) return false;
            var greutateArticole = GreutateCurenta + articol.Greutate;
            var volumArticole = VolumCurent + articol.Volum;

            if (GreutateMaxima < greutateArticole || VolumMaxim < volumArticole) return false;

            NumarCurent += 1;
            GreutateCurenta = greutateArticole;
            VolumCurent = volumArticole;

            return true;

        }

    }
}
