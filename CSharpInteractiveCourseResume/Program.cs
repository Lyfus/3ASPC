using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypesResume
{
    // Résumé des types basiques en C#
    class Program
    {
        static void Main(string[] args)
        {
            #region STRING
            // Déclaration d'une variable string fortement typée.
            // Utilisation de la syntaxe "camelCase" pour la déclaration de nom de variable.
            string firstString = "this is my first string";
            // Déclaration d'une variable implicitement typée. 
            // L'interpreteur comparera l'assignation faite à la variable pour en déduire son type.
            // Il ne faut pas oublier que C# comparé à Javascript, est un language FORTEMENT typé, et a besoin de connaitre le type 
            // d'une variable quoi qu'il arrive.
            var secondString = "this is my second string";
            #endregion
            #region CHAR
            // Déclaration implicite d'un CHAR
            var firstChar = 'A';
            #endregion
            #region NUMBERS
            // Déclaration d'un INTEGER
            var firstInt = 5;
            // Déclaration implicite d'un INTEGER
            var secondInt = 6;
            // La valeur maximum d'un INTEGER
            int bigInt = int.MaxValue; // 2147483647
            // Déclaration de la valeur maximum d'un uint (Integer ne pouvait pas être négatif)
            uint bigPositiveInt = uint.MaxValue; // 4294967295
            // Déclaration d'un SHORT
            short smallerNumber = 5; // short.MaxValue renvoie 32767
            // Déclaration d'un long
            // ulong retourne également le double d'un long, puisque nous sacrifions le côté négatif pour stocker un plus grand nombre
            long biggerNumber = 123234234234; // long.MaxValue renvoie 9223372036854775807
            // Déclaration d'un float
            float pie = 3.14f;
            // Déclaration d'un double
            double pie2 = 3.14;
            #endregion
            #region BOOLEAN
            // Déclaration d'un booléen
            bool personalTruth = true;
            // Déclaration implicite d'un booléen
            var thisIsFalse = false;
            #endregion
        }
    }
}
