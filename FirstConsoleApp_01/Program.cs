using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// le namespace ou espace de nom permet un isolement des blocs de codes à travers le programme
// Par exemple un client lourd composé de 500 fichiers ne doit pas voir tous ces fichiers à la racine
// Du projet, le développeur aura la tâche de structurer son code à travers des dossiers
// Ce qui menera le Namespace à évoluer. 
// Ici, le fichier "Program.cs" étant à la racine du projet, le namespace n'est pas compliqué mais 
// Il est courant de voir des namespace à 5 couches voire plus.
// Exemple : FirstConsoleApp_01.BusinessObject.PrimaryObject.DataBaseStructure.Context
namespace FirstConsoleApp_01
{
    // L'instruction class sert principalement à séparer le code en plusieurs "blocs"
    // Il est possible de mettre plusieurs class dans un seul fichier, mais la convention "standard" 
    // demande généralement le classique : "One file, One class", ce qui permet une meilleure visibilité
    // Du code et la bonne organisation du projet
    class Program
    {
        // Ici on veux montrer que l'on peux déclarer des variables en dehors d'une méthode, à la racine de la class
        // Pour pouvoir les utiliser dans toutes ses méthodes.
        // Ne faite pas attention au mot-clé "static" qui vous sera expliqué en détails plus tard
        public static string title = "C# Essential Training";
        public static int whichPart;

        static void Main(string[] args)
        {
            whichPart = 2; // Assignation basique d'une valeur à notre variable "whichPart"
            var message = string.Format("Welcome to {0} Part {1}!", title, whichPart); // On présente ici une façon de formater une chaine de caractère avec des variables..
            Console.WriteLine(message);
            Console.WriteLine("Press the Enter key to exit.");
            Console.ReadLine();
        }
    // Fermeture de la classe
    }
// Fermeture du Namespace
}
