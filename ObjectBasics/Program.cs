using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypesFonctionsResume
{
    // Résumé sur les objets en C#
    class Program
    {
        static void Main(string[] args)
        {
            // Pour commencer, tout est object en C#, même un type basique comme une chaine de caractère. 
            // Cette notion est très importante.
            // La preuve simple est qu'en déclarant par exemple "int", vous avez accès à des Méthodes
            // Qu'implémente l'objet "int"
            // Exemple : Passage d'une chaine de caractère en Integer
            int stringToInt = int.Parse("15"); // ici stringToInt aura la valeur 15 

            // Vous pouvez exploiter les méthodes de chaque type de base pour travailler
            // et vous serez souvent emmenés à utiliser ces méthodes. 

            #region STRING BASICS
            var testString = " abCDefg  ";

            // Nettoyage des espaces blancs
            testString.Trim(); // "abCDefg"
            testString.TrimStart(); // "abCDefg  "
            testString.TrimEnd(); // " abCDefg"

            // Minuscules et Majuscules
            var password = "P@ssw0rd";

            password.ToUpper(); // "P@SSW0RD"
            password.ToLower(); // "p@ssw0rd"

            // Travailler avec des morceaux de chaines de caractères
            var dickens = "It was the best times, it was the worst times.";
            dickens.Substring(4, 8); // "as the b"
            // Taille d'une chaine 
            var stringLength = dickens.Length; // 46


            // Exercice 
            // Vous devez utiliser tout ce que nous venons de voir pour obtenir : "REALLY GREAT"
            var challenge = " Text processing in C# is really great! ";
            #region SOLUTION
            challenge.Trim().Substring(24, challenge.Trim().Length - 25).ToUpper().Trim(); // "REALLY GREAT"
            #endregion
            #endregion
            #region STRING BUILDER
            // D'après l'intervenant, il montre que c'est laborieux de contatener des chaines de caractère
            // Avec la concatenation classique, et prèfère utiliser le string builder
            // Personnelement, je n'ai jamais rencontré le StringBuilder..
            // Mais c'est un outil à connaitre
            var stringOne = "Hello ";
            var stringTwo = "I love you ";
            var stringThree = "Won't you tell me your name?";
            // Concaténation en une seule chaine 
            var OneTwoThreeConcat = stringOne + stringTwo + stringThree; // "Hello I love you Won't you tell me your name?"

            // String Builder 
            var sb = new StringBuilder();
            // Ajout consécutif de chaine au StringBuilder
            sb.Append("It was the best of times, it was the worst of times");
            sb.Append("It was the age of wisdom");
            sb.Append("It was the age of foolishness");
            sb.ToString(); // "It was the best of times, it was the worst of timesIt was the age of wisdomIt was the age of foolishness"

            // Déclaration d'un nouveau StringBuilder avec un "Seed" Text
            sb = new StringBuilder("It was the best of times, it was the worst of times");
            sb.ToString(); // "It was the best of times, it was the worst of times"
            // Ajout d'une ligne avec retour à la ligne
            sb.AppendLine("It was the age of wisdom");
            sb.AppendLine("It was the age of foolishness");
            // On voit ici qu'après les deux lignes ajoutées, AppendLine a rajouté des caractères échappés correspondant à un saut de ligne : \r\n
            // Dans une console, ce texte serait affiché sur 2 lignes
            sb.ToString(); // "It was the best of times, it was the worst of timesIt was the age of wisdom\r\nIt was the age of foolishness\r\n"

            // Cette fois, l'intervenant veux montrer un texte bien formatté
            sb = new StringBuilder();
            // Ajout consécutif de chaine au StringBuilder
            sb.AppendLine("It was the best of times, it was the worst of times");
            sb.AppendLine("It was the age of wisdom");
            sb.AppendLine("It was the age of foolishness");
            sb.ToString(); // "It was the best of times, it was the worst of times\r\nIt was the age of wisdom\r\nIt was the age of foolishness\r\n"
            #endregion
            #region STRING FORMAT

            #endregion
        }
    }
}
