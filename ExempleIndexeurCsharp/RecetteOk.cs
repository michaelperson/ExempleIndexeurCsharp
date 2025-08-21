using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleIndexeurCsharp
{
    /// <summary>
    /// Classe représentant une recette de cuisine avec ses ingrédients
    /// Utilise un indexeur pour accéder aux ingrédients par index
    /// </summary>
    public class RecetteOk
    {
        // Champs privés pour stocker les données de la recette
        private string _nom;
        private string _description;
        private Dictionary<int,string> _ingredients = new();

        /// <summary>
        /// Propriété pour accéder au nom de la recette
        /// </summary>
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }

        /// <summary>
        /// Propriété pour accéder à la description de la recette
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        /// <summary>
        /// Propriété en lecture seule qui retourne le nombre d'ingrédients
        /// Retourne 0 si la liste n'est pas initialisée
        /// </summary>
        public int NbIngredients
        {
            get
            {
                return _ingredients?.Count ?? 0; // Utilise l'opérateur null-conditional pour éviter les erreurs
            }
        }

        /// <summary>
        /// Indexeur permettant d'accéder aux ingrédients par leur position dans le dictionnaire
        /// </summary>
        /// <param name="index">L'index de l'ingrédient à récupérer ou modifier</param>
        /// <returns>L'ingrédient à la position spécifiée</returns>
        public string this[int index]
        {
            get
            {
                // Vérification que le dictionnaire existe et que l'index est valide
                if (_ingredients == null || index < 0 || index >= _ingredients.Count)
                {
                    return null; // Retourne null si l'accès n'est pas valide
                }
                return _ingredients[index];
            }
            set
            {
                // Initialise la liste si elle n'existe pas encore
                _ingredients = _ingredients ?? new Dictionary<int, string>();

                // Vérifie si l'ingrédient existe déjà dans la liste pour éviter les doublons
                if (_ingredients.ContainsValue(value))
                {
                    Console.WriteLine("Attention : Cet ingrédient est déjà présent dans la recette !");
                    return; // Sort de la méthode sans ajouter le doublon
                }

                // S'assure que l'index n'est pas encore utilisé
                while (_ingredients.ContainsKey(index))
                {
                    Console.WriteLine("Attention : cet index est déjà utilisé!");
                    return; // Sort de la méthode  
                }

                // Assigne la nouvelle valeur à l'index spécifié
                _ingredients.Add(index, value);
            }
        }


    }
}