using System;
using System.IO;

namespace CarreMagique
{
    class Program
    {
        static void Main2(string[] args)
        {
            Test1 test1 = new Test1();

            test1.lancer();
        }
        static void Main(string[] args)
        {
            Uti.Info("Program", "Main", "");
            Uti.ReferencesProgramme("RODDE", "Alain", "carre-magique", "1.0.2");
            Menu menu = new Menu();
            menu.MethodesMenuJeu();
            Console.WriteLine();


        }
    }  

     
}

