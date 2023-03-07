using CalatoriaMagica.Obiecte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalatoriaMagica.Program;

namespace CalatoriaMagica.Utils
{
    public class Util
    {

        public int IntroduInt(string mesaj)
        {

            Console.Write($"\n{mesaj}");
            string valoare = Console.ReadLine();
            int num;
            while (!int.TryParse(valoare, out num))
            {
                Console.Clear();
                Console.WriteLine(Constante.mesajIntGresit);
                Console.Write(mesaj);
                valoare = Console.ReadLine();
            }
            return num;
        }

        public float IntroduFloat(string mesaj)
        {

            Console.Write($"\n{mesaj}");

            string valoare = Console.ReadLine();
            float num;
            while (!float.TryParse(valoare, out num))
            {
                Console.Clear();
                Console.WriteLine(Constante.mesajFloatGresit);
                Console.Write(mesaj);
                valoare = Console.ReadLine();
            }
            return num;
        }

        public void AfisareMeniu()
        {
            Console.WriteLine("\nAlegeti unul dintre tipurile de articole ce pot fi adaugate in ghiozdan:");
            Console.WriteLine("1. Sageata: greutate - 0.1; volum - 0.05");
            Console.WriteLine("2. Arc: greutate - 1; volum - 4");
            Console.WriteLine("3. Franghie: greutate - 1; volum - 1.5");
            Console.WriteLine("4. Apa: greutate - 2; volum - 3");
            Console.WriteLine("5. Portie de mancare: greutate - 1; volum 0.5");
            Console.WriteLine("6. Sabie: greutate - 5; volum - 3\n");
        }

        public void AfisareStatisticaGhiozdan(string mesajDepasire, Ghiozdan ghiozdan)
        {
            Console.Clear();
            Console.WriteLine(mesajDepasire);
            Console.WriteLine("Specificatiile ghiozdanului sunt:\n");
            Console.WriteLine($"Numar maxim de articole - actual: {ghiozdan.NumarMaxim} - {ghiozdan.NumarCurent}");
            Console.WriteLine($"Greutate maxima - actuala: {ghiozdan.GreutateMaxima} - {ghiozdan.GreutateCurenta}");
            Console.WriteLine($"Volum maxim - actual: {ghiozdan.VolumMaxim} - {ghiozdan.VolumCurent}");
        }

       
    }
}
