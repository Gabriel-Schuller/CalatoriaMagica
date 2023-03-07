namespace CalatoriaMagica
{
    internal class Program
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

        public class Sageata : ArticolInventar
        {
            public Sageata() : base(0.1f, 0.05f)
            {
            }
        }
        public class Arc : ArticolInventar
        {
            public Arc() : base(1f, 4f)
            {
            }
        }
        public class Franghie : ArticolInventar
        {
            public Franghie() : base(1f, 1.5f)
            {
            }
        }
        public class Apa : ArticolInventar
        {
            public Apa() : base(2f, 3f)
            {
            }
        }
        public class PortieMancare : ArticolInventar
        {
            public PortieMancare() : base(1f, 0.5f)
            {
            }
        }
        public class Sabie : ArticolInventar
        {
            public Sabie() : base(5f, 3f)
            {
            }
        }

        public static int IntroduInt(string mesaj)
        {

            Console.Write($"\n{mesaj}");
            string valoare = Console.ReadLine();
            int num;
            while (!int.TryParse(valoare, out num))
            {
                Console.Clear();
                Console.WriteLine("Nu ati introdus o valoare corecta. Numarul maxim trebuie sa fie un numar intreg!");
                Console.Write(mesaj);
                valoare = Console.ReadLine();
            }
            return num;
        }

        public static float IntroduFloat(string mesaj)
        {

            Console.Write($"\n{mesaj}");

            string valoare = Console.ReadLine();
            float num;
            while (!float.TryParse(valoare, out num))
            {
                Console.Clear();
                Console.WriteLine("Nu ati introdus o valoare corecta!");
                Console.Write(mesaj);
                valoare = Console.ReadLine();
            }
            return num;
        }

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

        static void Main(string[] args)
        {
            var sageata = new Sageata();
            var arc = new Arc();
            var franghie = new Franghie();
            var apa = new Apa();
            var portie = new PortieMancare();
            var sabie = new Sabie();


            string mesajNrMaxim = "Introduceti numarul maxim de articole ce pot fi introduse in ghiozdan: ";
            string mesajGreutateMaxima = "Introduceti greutatea maxima a articolelor: ";
            string mesajVolumMaxim = "Introduceti volumul maxim al articolelor: ";

            int numarMaxim = IntroduInt(mesajNrMaxim);
            float greutateMaxima = IntroduFloat(mesajGreutateMaxima);
            float volumMaxim = IntroduFloat(mesajVolumMaxim);

            Ghiozdan ghiozdan = new Ghiozdan(numarMaxim, greutateMaxima, volumMaxim);
            string mesajDepasire = "";
            while (mesajDepasire != "exit")
            {
                Console.Clear();
                Console.WriteLine(mesajDepasire);
                Console.WriteLine("Specificatiile ghiozdanului sunt:\n");
                Console.WriteLine($"Numar maxim de articole - actual: {ghiozdan.NumarMaxim} - {ghiozdan.NumarCurent}");
                Console.WriteLine($"Greutate maxima - actuala: {ghiozdan.GreutateMaxima} - {ghiozdan.GreutateCurenta}");
                Console.WriteLine($"Volum maxim - actual: {ghiozdan.VolumMaxim} - {ghiozdan.VolumCurent}");

                Console.WriteLine("\nAlegeti unul dintre tipurile de articole ce pot fi adaugate in ghiozdan:");
                Console.WriteLine("1. Sageata: greutate - 0.1; volum - 0.05");
                Console.WriteLine("2. Arc: greutate - 1; volum - 4");
                Console.WriteLine("3. Franghie: greutate - 1; volum - 1.5");
                Console.WriteLine("4. Apa: greutate - 2; volum - 3");
                Console.WriteLine("5. Portie de mancare: greutate - 1; volum 0.5");
                Console.WriteLine("6. Sabie: greutate - 5; volum - 3\n");

                if (ghiozdan.NumarCurent == ghiozdan.NumarMaxim)
                {
                    Console.WriteLine("Ati atins numarul maxim de artefacte din ghiozdan. Mult succes la drum!");
                    break;
                }
                Console.Write("Valoarea aleasa(pentru a iesi scrieti 'exit'): ");

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

                    case "exit":
                        Console.Clear();
                        Console.WriteLine("La revedere!");
                        mesajDepasire = "exit";
                        break;

                    default:
                        mesajDepasire = "Nu ati introdus o valoare corecta, va rugam selectati una dintre optiuni! ";
                        break;
                }

                

                if (!potAdaugaArtefactul)
                    mesajDepasire = "S-a depasit capacitatea! Puteti incerca sa introduceti alt artefact";
            }



        }
    }
}