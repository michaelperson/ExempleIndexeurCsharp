// See https://aka.ms/new-console-template for more information
using ExempleIndexeurCsharp;

Console.WriteLine("Exemple d'indexeur - Recette");
Recette cakeAuxPommes = new Recette();
cakeAuxPommes.Nom = "Cake aux Pommes façon grand-mère";
cakeAuxPommes.Description = "Retrouvez le goût de votre enfance avec cette recette ancestrale du cake aux pommes traditionnel";
cakeAuxPommes[0] = "Beurre";
cakeAuxPommes[0] = "Farine";
cakeAuxPommes[0] = "Eau pétillante";
cakeAuxPommes[0] = "Des pommes congelées de la marque Malbouffe";
cakeAuxPommes[0] = "sucre de canne";
cakeAuxPommes[0] = "sucre blanc";
cakeAuxPommes[0] = "sucre perlé";
cakeAuxPommes[0] = "sucre vanillé";

Console.WriteLine("Affichage de la recette");
Console.WriteLine(cakeAuxPommes.Nom);
Console.WriteLine(cakeAuxPommes.Description);
Console.WriteLine("Ingrédients");
 
for(int i = 0;i< cakeAuxPommes.NbIngredients;i++)
{
    Console.WriteLine($"{i}: {cakeAuxPommes[i]}");
}
