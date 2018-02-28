using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Program
    {
        /*
        static int CalculSommeEntiers(int debut, int fin)
        {
            int somme = 0;

            for (int i = debut; i <= fin; i++)
            {
                somme += i;
            }

            return somme;
        }

        static double CalculMoyenne(List<double> liste)
        {
            double total = 0;
            double moyenne = 0;
            int nombreElement = liste.Count;

            foreach (double element in liste)
            {
                total += element;
            }

            moyenne = total / nombreElement;

            return moyenne;
        }

        static int CalculElement()
        {
            List<int> multipleTrois = new List<int>();
            List<int> multipleCinq = new List<int>();
            int result = 0;

            for (int i = 0; i <= 100; i++)
            {
                multipleTrois.Add(i * 3);
            }

            for (int i = 0; i <= 100; i++)
            {
                multipleCinq.Add(i * 5);
            }

            foreach (int chiffreTrois in multipleTrois)
            {
                foreach (int chiffreCinq in multipleCinq)
                {
                    if (chiffreTrois == chiffreCinq)
                    {
                        result += chiffreTrois;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(CalculSommeEntiers(1, 10));
            //Console.WriteLine(CalculSommeEntiers(1, 100));

            //List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            //Console.WriteLine(CalculMoyenne(liste));

            //Console.WriteLine(CalculElement());
        }
        */

        static void Main(string[] args)
        {
            List<int> numerosLoto = CreationGrilleLoto(1, 49);

            int[] loto = CreationLoto(7, numerosLoto);

            AffichageNumeroLoto(loto);
        }

        static List<int> CreationGrilleLoto(int numMinLoto, int numMaxLoto)
        {
            List<int> grilleLoto = new List<int>();

            for (int i = numMinLoto; i <= numMaxLoto; i++)
            {
                grilleLoto.Add(i);
            }

            return grilleLoto;
        }

        static int[] CreationLoto(int nombreBouleLoto, List<int> numerosLoto)
        {
            int[] loto = new int[nombreBouleLoto];

            for (int i = 0; i < loto.Length; i++)
            {
                Random randNum = new Random();
                int numeroAleatoire = numerosLoto[randNum.Next(numerosLoto.Count)];

                loto[i] = numeroAleatoire;
                numerosLoto.Remove(numeroAleatoire);
            }

            return loto;
        }

        static void AffichageNumeroLoto(int[] loto)
        {
            foreach (int numeroLoto in loto)
            {
                Console.WriteLine(numeroLoto);
            }
        }
    }
}
