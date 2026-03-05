using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ti_Marcel_Matrice
{
    public static class MethodeDuProjet
    {

        /// <summary>
        /// Lit un nombre entier
        /// </summary>
        public static void LireEntier(string question, out int n)
        {
            string saisie;
            do
            {
                Console.Write(question);
                saisie = Console.ReadLine();
            } while (!int.TryParse(saisie, out n));
        }

        /// <summary>
        /// Lit et vérifie les bornes min et max
        /// </summary>
        public static void LireBornes(out int min, out int max)
        {
            do
            {
                LireEntier("Minimum : ", out min);
                LireEntier("Maximum : ", out max);

                if (min >= max)
                {
                    Console.WriteLine("Erreur : le minimum doit être plus petit que le maximum !");
                }
            } while (min >= max);
        }

        /// <summary>
        /// Remplit la matrice avec des nombres aléatoires
        /// </summary>
        public static void CreerMatriceAleatoire(int lignes, int colonnes, int min, int max, out int[,] matrice)
        {
            Random hasard = new Random();
            matrice = new int[lignes, colonnes];

            Console.WriteLine("\nGénération aléatoire en cours...");

            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    matrice[i, j] = hasard.Next(min, max + 1);
                }
            }

            Console.WriteLine("Terminé !");
        }

        /// <summary>
        /// Affiche la matrice à l'écran
        /// </summary>
        public static void AfficherMatrice(int[,] matrice)
        {
            int lignes = matrice.GetLength(0);
            int colonnes = matrice.GetLength(1);

            Console.WriteLine("\n--- MATRICE ---");

            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine(); // Retour à la ligne
            }

            Console.WriteLine("\nDimensions : " + lignes + " x " + colonnes);
        }
    }
}
