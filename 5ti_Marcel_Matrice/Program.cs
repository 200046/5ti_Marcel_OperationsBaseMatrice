using _5ti_Marcel_Matrice;

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
                MethodeDuProjet.LireEntier("Nombre de lignes : ", out lignes);
                MethodeDuProjet.LireEntier("Nombre de colonnes : ", out colonnes);

                // 2. Demander les bornes
                MethodeDuProjet.LireBornes(out min, out max);

                // 3. Créer la matrice avec des valeurs aléatoires
                MethodeDuProjet.CreerMatriceAleatoire(lignes, colonnes, min, max, out matrice);

                // 4. Afficher la matrice
                MethodeDuProjet.AfficherMatrice(matrice);

                // 5. Recommencer ?
                Console.WriteLine("\nEspace = recommencer, autre touche = quitter");
                reponse = Console.ReadLine();

            } while (reponse == " ");
        }

    }
}