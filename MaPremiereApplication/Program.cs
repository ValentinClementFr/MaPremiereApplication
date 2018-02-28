using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPremiereApplication
{
    class Program
    {     
        static void Main(string[] args)
        {
            string utilisateur = Environment.UserName;
            int heureCourante = DateTime.Now.Hour;

            if(DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                if(heureCourante < 9)
                {
                    Console.WriteLine("Bon week-end " + utilisateur);
                }
                else if (heureCourante >= 9 && heureCourante <= 18)
                {
                    Console.WriteLine("Bonjour " + utilisateur);
                }
                else if (heureCourante > 18)
                {
                    Console.WriteLine("Bonsoir " + utilisateur);
                }
            }
            if(DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday || DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                if(heureCourante >= 9 && heureCourante <= 18)
                {
                    Console.WriteLine("Bonjour " + utilisateur);
                }
                else if(heureCourante < 9 || heureCourante > 18)
                {
                    Console.WriteLine("Bonsoir " + utilisateur);
                }
            }
            else if(DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                if(heureCourante < 9)
                {
                    Console.WriteLine("Bonsoir " + utilisateur);
                }
                else if (heureCourante >= 9 && heureCourante <= 18)
                {
                    Console.WriteLine("Bonjour " + utilisateur);
                }
                else if(heureCourante > 18)
                {
                    Console.WriteLine("Bon week-end " + utilisateur);
                }
            }
            else if(DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Bon week-end " + utilisateur); 
            }
        }
    }
}
