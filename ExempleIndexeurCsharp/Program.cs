// See https://aka.ms/new-console-template for more information
using ExempleIndexeurCsharp;

Console.WriteLine("Exemple d'indexeur - Recette");
//Version Critiques
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
Console.WriteLine("");
Console.WriteLine("Affichage de la recette");
Console.WriteLine(cakeAuxPommes.Nom);
Console.WriteLine(cakeAuxPommes.Description);
Console.WriteLine("Ingrédients");
 
for(int i = 0;i< cakeAuxPommes.NbIngredients;i++)
{
    Console.WriteLine($"{i}: {cakeAuxPommes[i]}");
}
Console.WriteLine("==========================");
Console.WriteLine("");
//Version ok
RecetteOk cakeAuxPommesOk = new RecetteOk();
cakeAuxPommesOk.Nom = "Cake aux Pommes façon grand-mère";
cakeAuxPommesOk.Description = "Retrouvez le goût de votre enfance avec cette recette ancestrale du cake aux pommes traditionnel";

cakeAuxPommesOk[0] = "Beurre";
cakeAuxPommesOk[0] = "Beurre qui ne sera pas ajouté car index déjà utilisé";
cakeAuxPommesOk[1] = "Farine";
cakeAuxPommesOk[2] = "Eau pétillante";
cakeAuxPommesOk[3] = "Des pommes congelées de la marque Malbouffe";
cakeAuxPommesOk[4] = "sucre de canne";
cakeAuxPommesOk[5] = "sucre blanc";
cakeAuxPommesOk[6] = "sucre perlé";
cakeAuxPommesOk[7] = "sucre vanillé";
Console.WriteLine("");
Console.WriteLine("Affichage de la recette (OK)");
Console.WriteLine(cakeAuxPommesOk.Nom);
Console.WriteLine(cakeAuxPommesOk.Description);
Console.WriteLine("Ingrédients");

for (int i = 0; i < cakeAuxPommesOk.NbIngredients; i++)
{
    Console.WriteLine($"{i}: {cakeAuxPommesOk[i]}");
}

