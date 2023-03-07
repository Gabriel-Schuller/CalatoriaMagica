using CalatoriaMagica.Obiecte;
using CalatoriaMagica.Utils;

namespace CalatoriaMagica
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var utils = new Util();

            int numarMaxim = utils.IntroduInt(Constante.mesajNrMaxim);
            float greutateMaxima = utils.IntroduFloat(Constante.mesajGreutateMaxima);
            float volumMaxim = utils.IntroduFloat(Constante.mesajVolumMaxim);

            Ghiozdan ghiozdan = new Ghiozdan(numarMaxim, greutateMaxima, volumMaxim);
            string mesajDepasire = "";

            while (mesajDepasire != Constante.conditieExit)
            {
                utils.AfisareStatisticaGhiozdan(mesajDepasire, ghiozdan);
                utils.AfisareMeniu();

                if (ghiozdan.NumarCurent == ghiozdan.NumarMaxim)
                {
                    Console.WriteLine(Constante.nrMaximAtins);
                    break;
                }

                Console.Write(Constante.alegereValoareMeniu);
                string artefactulAles = Console.ReadLine();
                bool potAdaugaArtefactul = true;

                switch (artefactulAles)
                {
                    case "1":
                        potAdaugaArtefactul = ghiozdan.Adauga(new Sageata());
                        break;

                    case "2":
                        potAdaugaArtefactul = ghiozdan.Adauga(new Arc());
                        break;

                    case "3":
                        potAdaugaArtefactul = ghiozdan.Adauga(new Franghie());
                        break;

                    case "4":
                        potAdaugaArtefactul = ghiozdan.Adauga(new Apa());
                        break;

                    case "5":
                        potAdaugaArtefactul = ghiozdan.Adauga(new PortieMancare());
                        break;

                    case "6":
                        potAdaugaArtefactul = ghiozdan.Adauga(new Sabie());
                        break;

                    case Constante.conditieExit:
                        Console.Clear();
                        Console.WriteLine(Constante.mesajExit);
                        mesajDepasire = Constante.conditieExit;
                        break;

                    default:
                        mesajDepasire = Constante.selectieGresitaMeniu;
                        break;
                }

                if (!potAdaugaArtefactul)
                    mesajDepasire = Constante.capacitateDepasita;
            }
        }
    }
}