int[] tab;
int length;
string str;
int rev;

// Fonction qui permet de saisir la taille et les valeurs du tableau
int[] Saisie()
{
    Console.WriteLine("Saisir la taille du tableau"); // Demande à l'utilisateur la taille du tableau
    str = Console.ReadLine();
    length = Convert.ToInt32(str);

    tab = new int[length]; // Taille choisie par l'utilisateur assignée au tableau

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Saisir l'élément {i}");
        str = Console.ReadLine(); // Demande à l'utilisateur la valeur pour la case i du tableau
        tab[i] = Convert.ToInt32(str); // Assignation de cette valeur à la case i
    }
    return tab;
}

// Fonction qui permet d'afficher le tableau

int[] PrintTab()
{
    Console.WriteLine("Vous avez saisi:");

    foreach (int i in tab) // Boucle qui affiche la valeur de la case du tableau à l'indice i, ce qui affiche au final l'ensemble du tableau
    {
        Console.WriteLine(i);
    }
    return tab;
}

// Fonction qui permet d'afficher le tableau inversé

int[] PrintReverseTab()
{

    Console.WriteLine("Le tableau inversé est:");

    for (int i = length - 1; i >= 0; i--) // Boucle qui permet de parcourir le tableau de droite à gauche (à l'envers)
    {
        rev = tab[i]; // Stockage de la valeur du tableau à l'indice i dans la variable rev
        Console.WriteLine(rev);
    }

    return tab;
}

// Appel des fonctions

Saisie();
PrintTab();
PrintReverseTab();
