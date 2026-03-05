namespace _5TTI_MARCEL_Matrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans mon programme de matrices !");

            string reponse;      // Pour recommencer ou pas
            int lignes;          // Nombre de lignes
            int colonnes;        // Nombre de colonnes
            int min;             // Valeur minimum
            int max;             // Valeur maximum
            int[,] matrice;      // La matrice

            do
            {
                // 1. Demander les dimensions
                LireEntier("Nombre de lignes : ", out lignes);
                LireEntier("Nombre de colonnes : ", out colonnes);

                // 2. Demander les bornes
                LireBornes(out min, out max);

                // 3. Créer la matrice avec des valeurs aléatoires
                CreerMatriceAleatoire(lignes, colonnes, min, max, out matrice);

                // 4. Afficher la matrice
                AfficherMatrice(matrice);

                // 5. Recommencer ?
                Console.WriteLine("\nEspace = recommencer, autre touche = quitter");
                reponse = Console.ReadLine();

            } while (reponse == " ");
        }

        /// <summary>
        /// Lit un nombre entier
        /// </summary>
        static void LireEntier(string question, out int n)
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
        static void LireBornes(out int min, out int max)
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
        static void CreerMatriceAleatoire(int lignes, int colonnes, int min, int max, out int[,] matrice)
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
        static void AfficherMatrice(int[,] matrice)
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