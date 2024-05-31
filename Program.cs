int[] tab;
int length;
string str;

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
