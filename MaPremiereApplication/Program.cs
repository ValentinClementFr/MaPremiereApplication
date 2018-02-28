using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Program
    {
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

            foreach(double element in liste)
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
                    if(chiffreTrois == chiffreCinq)
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

        
    }
}
