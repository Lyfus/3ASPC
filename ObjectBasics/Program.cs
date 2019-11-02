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
        #region ENUMS
        // Déclaration d'une énumeration, pas possible dans une méthode d'une class.
        // Déclarer son énumeration directement dans la class.
        // Concerne l'énumeration du chapitre "CONSTANTS_ENUMERATORS
        enum weekDays { Monday, Tuesday, Wednesday, Thursday, Friday };

        // Déclaration d'une énumeration avec début d'énumération à 1, 0 par défault 
        enum weekDaysWithStart { Monday = 1, Tuesday, Wednesday, Thursday, Friday };
        #endregion
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
            // Documentation MSDN sur le string.Format
            // https://docs.microsoft.com/fr-fr/dotnet/api/system.string.format?view=netframework-4.8

            var city = "Dallas";
            var temperature = 103.4f;
            // DateTime.Now donne la date actuelle au format DateTime
            var currentDt = DateTime.Now;
            // string.Format permet de remplacer tous les {Nbr} par des variables pour construire une chaine de caractère rapidement
            // selon des éléments qui peuvent être variables. 
            // C'est la méthode la plus employée dans des projets pour formater des string avec des données venant par exemple d'une API
            // Ou d'une Bdd directe.
            string.Format("Welcome to {0}. The time is {1}. The Temperature is {2}.", city, currentDt, temperature);
            // "Welcome to Dallas. The time is 02/11/2019 10:26:50. The Temperature is 103,4."

            // Cette fois, le paramètre {1} a été formaté avec un paramètre d'affichage correspondant à une "shortDateFormat"
            // Pour connaitre tous les formats de dates, rendez vous sur le MSDN (documentation microsoft)
            // https://docs.microsoft.com/fr-fr/dotnet/standard/base-types/custom-date-and-time-format-strings
            string.Format("Welcome to {0}. The time is {1:t}. The Temperature is {2}.", city, currentDt, temperature);
            // "Welcome to Dallas. The time is 10:32. The Temperature is 103,4."

            // Format "LongDateFormat" du paramètre {1}
            string.Format("Welcome to {0}. The time is {1:T}. The Temperature is {2}.", city, currentDt, temperature);
            // "Welcome to Dallas. The time is 10:32:55. The Temperature is 103,4."

            // Format de température du paramètre {2}
            string.Format("Welcome to {0}. The time is {1:T}. The Temperature is {2:0.00}.", city, currentDt, temperature);
            // "Welcome to Dallas. The time is 10:32:55. The Temperature is 103,40."

            temperature = 1000.25f;
            // Autre format de température du paramètre {2}
            string.Format("Welcome to {0}. The time is {1:T}. The Temperature is {2:0,0.00}.", city, currentDt, temperature);
            // "Welcome to Dallas. The time is 10:32:55. The Temperature is 1 000,25."
            #endregion
            #region STRING TO INT
            // Comme vu précédement, une chaine de caractère peux devenir un entier par un cast 
            int.Parse("15"); // 15

            // Si nous essayons de parser un nombre à virgule (flottant), une erreur se produira
            int.Parse("15,234"); // Error : Input string was not in a correct format

            var test = "15,234";
            // Ici test est transformé en int par l'intermédiaire d'une méthode native de l'objet string "Replace"
            // En remplacant la virgule par une chaine vide, test devient alors une chaine castable en entier.
            int.Parse(test.Replace(",", "")); // 15234

            int result;
            // ATTENTION, TryParse retourne TOUJOURS un booléen !
            // TryParse fonctionne avec deux paramètres : 
            // 1 - La chaine à cast en entier
            // 2 - la valeur "out" permet de produire un résultat en cas de réussite du TryParse
            // Si la chaine est castable, ici le resultat sera alors enregistré dans la variable result
            // Ici, comme la chaine n'est pas castable en int, TryParse retournera un booléen False
            // TryParse est surtout utilisé pour vérifier si une entrée est possiblement castable dans un type donné. 
            int.TryParse("15,234", out result); // False

            // Exemple d'un fonctionnel
            int.TryParse("15234", out result); // True et result sera égal à 15234

            // RAPPEL : TryParse fonctionne avec TOUS les types natifs, long, float, etc...

            #endregion
            #region MATHS BASICS
            // Excusez mon ton sarcastique, mais ces chapitres de Maths basics me font fondre le cerveau tellement j'en ai mangé. 

            // Commençons par le basique du basique.. 
            // Additioner, soustraire, multiplier et diviser se fait par les symboles standards de tous langages qui se respectent.. 
            var SimpleAddition = 5 + 5; // 10, Ouaw !
            var SimpleSoustraction = 6 - 1; // 5, O-U-A-W !
            var SimpleMultiplication = 7 * 3; // 21, on a compris...
            var SimpleDivision = 21 / 7; // 3, Bon c'était le dernier. 
            var Modulo = 5 % 2; // 1, modulo, classique.

            var Test = 5;
            Test = Test + 1; // Incrémentation explicite visuellement
            // Test est alors égal à 6, des fois que certains ne suivraient pas.
            Test++; // Incrémentation implicite, on utilisera que celle ci, le var = var + 1 n'étant jamais utilisé pour sa lourdeur visuel. 
            // Test est alors égal à 7...
            Test--; // Décrémentation implicite, on vous explique que ceci revient à faire var  = var -1, merci docteur obvious.
            // Et donc on se retrouve avec Test égal à 6. *clap clap*
            Test += 5; // Raccourci d'addition pour un entier, concaténation pour une chaîne de caractère
            // 11
            Test -= 5; // Raccourci de soustraction
            // 6

            // Valeure absolue d'un nombre
            Math.Abs(-5); // 5

            // Fonction pour mettre un nombre (paramètre 1), à la puissance désirée
            // Ici nous faisant 5 au carré.
            Math.Pow(5, 2); // 25

            // Fonction Arrondie
            Math.Round(5.2); // 5

            // Fonction Tronquer (Suppression de la valeur après la virgule)
            Math.Round(5.8); // 5

            // Fonction Tronquer (à l'entier supérieur)
            Math.Ceiling(5.2); // 6
            #endregion
            #region CONSTANTS_ENUMERATORS
            // Déclaration d'une constante
            // Une fois la constante initialisée, sa valeur ne peux plus être modifiée.
            const float pi = 3.14f;

            // Pour la déclaration d'une énumération, voir la région "ENUM" à la racine de la classe
            // Pour les exemples d'après, l'enumération se trouve à la racine de la class.

            // Utilisation d'une valeur d'une enum
            var someDay = weekDays.Monday; // Monday
            #endregion
            #region DATES_TIMES

            // Get de la date actuelle
            var actualTime = DateTime.Now; // [02/11/2019 12:00:32]

            // Déclaration d'une nouvelle date
            var birthday = new DateTime(1993, 03, 28);
            // Différence entre la date actuelle et mon anniversaire, ce qui nous donne un temps en jour et quelques heures.
            var difference = DateTime.Now - birthday; // [9715.12:02:38.3313553]
            // Format en jours
            var DaysOfLife = difference.Days; // 9715 jours.
            // Conversion en année
            var YearsOfLife = difference.Days / 365; // 26 ans.

            // Autre façon de déclarer une date plus précisement (Voir constructeurs de l'objet)
            var SomeTime = new DateTime(2017, 10, 18, 9, 51, 32);
            // Ajout de minutes à la date "SomeTime"
            SomeTime.AddMinutes(134); // [18/10/2017 12:05:32]h
            // Soustraction de minutes
            SomeTime.AddMinutes(-30); // [18/10/2017 09:21:32]

            // Conversion en FileTime
            SomeTime.ToFileTime(); // 131527866920000000

            // Conversion en LongDateString
            SomeTime.ToLongDateString(); // "mercredi 18 octobre 2017"
            #endregion
        }
    }
}
