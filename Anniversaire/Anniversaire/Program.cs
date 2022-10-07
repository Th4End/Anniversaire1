using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anniversaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
         Console.Title = "Souhaiteur d'Anniversaire";
         Console.ForegroundColor = ConsoleColor.Yellow;
         int jactu, moisactu, anneeactu, jnaiss, moisnaiss, anneenaiss, age;
         jactu = DateTime.Now.Day;
         moisactu = DateTime.Now.Month;
         anneeactu = DateTime.Now.Year;
         Console.WriteLine("\nQuelle est ton jour de naissance ?");
         jnaiss = int.Parse(Console.ReadLine());
         Console.WriteLine("Quelle est ton Mois de naissance");
         moisnaiss = int.Parse(Console.ReadLine());
         Console.WriteLine("Ton année de naissance");
         anneenaiss = int.Parse(Console.ReadLine());
         age = anneeactu - anneenaiss;
         Console.ForegroundColor = ConsoleColor.Magenta;
         if (jnaiss == jactu && moisnaiss == moisactu)
          {
           Console.WriteLine("Joyeux anniversaire, ton age est de" + age);
           Console.ReadLine();
          }
            
                return;
            


        }

    }
}
