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
    public class Recette
    {
        // Champs privés pour stocker les données de la recette
        private string _nom;
        private string _description;
        private List<string> _ingredients=new();

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
        /// Indexeur permettant d'accéder aux ingrédients par leur position dans la liste
        /// </summary>
        /// <param name="index">L'index de l'ingrédient à récupérer ou modifier</param>
        /// <returns>L'ingrédient à la position spécifiée</returns>
        public string this[int index]
        {
            get
            {
                // Vérification que la liste existe et que l'index est valide
                if (_ingredients == null || index < 0 || index >= _ingredients.Count)
                {
                    return null; // Retourne null si l'accès n'est pas valide
                }
                return _ingredients[index];
            }
            set
            {
                // Initialise la liste si elle n'existe pas encore
                _ingredients = _ingredients ?? new List<string>();

                // Vérifie si l'ingrédient existe déjà dans la liste pour éviter les doublons
                if (_ingredients.Contains(value))
                {
                    Console.WriteLine("Attention : Cet ingrédient est déjà présent dans la recette !");
                    return; // Sort de la méthode sans ajouter le doublon
                }

                // S'assure que la liste a suffisamment d'éléments pour l'index demandé
                while (_ingredients.Count <= index)
                {
                    _ingredients.Add(string.Empty); // Ajoute des chaînes vides pour combler les trous
                }

                // Assigne la nouvelle valeur à l'index spécifié
                _ingredients[index] = value;
            }
        }

        /// <summary>
        /// Constructeur par défaut qui initialise la liste d'ingrédients
        /// </summary>
        public Recette()
        {
            _ingredients = new List<string>();
        }

        /// <summary>
        /// Constructeur avec paramètres pour initialiser une recette complète
        /// </summary>
        /// <param name="nom">Le nom de la recette</param>
        /// <param name="description">La description de la recette</param>
        public Recette(string nom, string description) : this()
        {
            _nom = nom;
            _description = description;
        }
    }
}