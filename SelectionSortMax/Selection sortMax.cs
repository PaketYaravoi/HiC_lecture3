int[] array = { 1, 2, 9, 4, 6, 4, 2, 15, 247 };

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    { 
        Console.Write($"{mass[i]}, ");
    }
}

void SelectionSortInMax(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        int posMax = i;

        for (int j = i + 1; j < mass.Length; j++)
        { 
            if (mass[j] > mass[posMax]) posMax = j;
        }

        int temp = mass[i];
        mass[i] = mass[posMax];
        mass[posMax] = temp;
    }

}

PrintArray(array);

SelectionSortInMax(array);
Console.WriteLine();

PrintArray(array);