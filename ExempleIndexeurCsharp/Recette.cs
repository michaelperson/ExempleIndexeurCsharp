using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleIndexeurCsharp
{
    public class Recette
    {
        string _nom;
        string _description;
        List<string> _ingredients;

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

        public int NbIngredients
        {
            get { return _ingredients.Count; }
        }

        public string this[int index]
        {
            get 
            {
               string? retour = null;
               if(_ingredients == null) { return retour; }
               return _ingredients[index];
            }
            set {
                _ingredients = _ingredients ?? new List<string>();
                if (_ingredients.Contains(value)) {
                    Console.WriteLine("Imbecile tu as déjà donné cet ingrédient va dormir!!!");
                }
                _ingredients.Add("");
                _ingredients[index]=(value);
            
            }
        }
    }
}
