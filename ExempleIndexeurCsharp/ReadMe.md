# Exemple d’Indexeur en C#

Ce projet illustre l’utilisation d’un **indexeur** appliqué à une liste d’ingrédients dans une recette.  
Il met en avant la **puissance** mais aussi les **risques** liés à une mauvaise maîtrise des indices.

---

## Objectif pédagogique

- Comprendre comment définir et utiliser un **indexeur** (`this[int index]`) en C#.  
- Mettre en évidence que l’indexeur peut **masquer la logique interne** de la collection.  
- Montrer les **comportements erratiques** possibles si les indices sont mal gérés.   

---

## Principe démontré

Dans l’implémentation :

- La classe `Recette` contient une liste `_ingredients`.  
- L’indexeur :  
  - Initialise la liste si besoin.  
  - Ajoute systématiquement une case vide (`Add("")`) avant de la remplacer par la valeur affectée.  
  - Affiche un message si l’ingrédient existe déjà.  

👉 Ce mécanisme fonctionne tant que l’on utilise des indices **séquentiels (0, 1, 2, …)**.  
👉 Si un indice est mal utilisé (sauté ou répété), on obtient un **comportement imprévisible**.

---

## Exemple d’utilisation

```csharp
// See https://aka.ms/new-console-template for more information
using ExempleIndexeurCsharp;

Console.WriteLine("Exemple d'indexeur - Recette");
Recette cakeAuxPommes = new Recette();
cakeAuxPommes.Nom = "Cake aux Pommes façon grand-mère";
cakeAuxPommes.Description = "Retrouvez le goût de votre enfance avec cette recette ancestrale du cake aux pommes traditionnel";

// Ajout des ingrédients (tous via l’index 0)
cakeAuxPommes[0] = "Beurre";
cakeAuxPommes[0] = "Farine";
cakeAuxPommes[0] = "Eau pétillante";
cakeAuxPommes[0] = "Des pommes congelées de la marque Malbouffe";
cakeAuxPommes[0] = "sucre de canne";
cakeAuxPommes[0] = "sucre blanc";
cakeAuxPommes[0] = "sucre perlé";
cakeAuxPommes[0] = "sucre vanillé";

// Affichage
Console.WriteLine("Affichage de la recette");
Console.WriteLine(cakeAuxPommes.Nom);
Console.WriteLine(cakeAuxPommes.Description);
Console.WriteLine("Ingrédients");

for (int i = 0; i < cakeAuxPommes.NbIngredients; i++)
{
    Console.WriteLine($"{i}: {cakeAuxPommes[i]}");
}
```

### Sortie attendue

```
Exemple d'indexeur - Recette
Affichage de la recette
Cake aux Pommes façon grand-mère
Retrouvez le goût de votre enfance avec cette recette ancestrale du cake aux pommes traditionnel
Ingrédients
0: Beurre
1: Farine
2: Eau pétillante
3: Des pommes congelées de la marque Malbouffe
4: sucre de canne
5: sucre blanc
6: sucre perlé
7: sucre vanillé
```

---

### Sortie Réelle

```
Exemple d'indexeur - Recette
Affichage de la recette
Cake aux Pommes façon grand-mère
Retrouvez le goût de votre enfance avec cette recette ancestrale du cake aux pommes traditionnel
Ingrédients
0: sucre vanillé
1:  
2:  
3:  
4:  
5:  
6:  
7:  
```
 
---

## Conclusion

Cet exemple montre :  

- Comment utiliser un **indexeur** en C#.  
- Les **risques** lorsqu’on masque trop la logique interne d’une collection.   

👉 L’indexeur est un outil puissant, mais il doit être manipulé avec précaution pour éviter des comportements inattendus.
