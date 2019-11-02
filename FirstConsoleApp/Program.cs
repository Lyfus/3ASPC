using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine permet d'écrire dans la console et d'insérer un retour chariot (saut à la ligne) après la ligne. 
            Console.WriteLine("Welcome to C# Essential Training Part 1");
            Console.WriteLine("Press enter to continue");

            // Actuellement, si nous compilons le programme tel quel avec ces deux lignes, vous n'aurez pas le temps de les voir apparaitre
            // L'intervenant de la vidéo explique qu'une application console a besoin d'être mise en "pause"
            // Cela se fait grâce à la commande Console.ReadLine() qui récupère une saisie utilisateur sous forme de string. 
            Console.ReadLine();
        }
    }
}
