int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] mass)
{
    int length = mass.Length;
    for (int i = 0; i < length; i++)
    { 
        Console.Write($"{mass[i]} ");
    }
}


//void selectionSort(int[] array)
//{
//    for (int i = 0; i < array.Length - 1; i++)
//    {
//        int minPosition = i;
//        for (int j = i + 1; j < array.Length; j++)
//        {
//            if (array[j] < array[minPosition]) minPosition = j;
//            {
//                minPosition = j
//            }
//        }
//        int temporary = array[i]
//    array[i] = array[minPosition];
//        array[minPosition] = temporary;
//    }
//}
PrintArray(arr);


void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length -1 ; i ++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {

            if (arr[j] < arr[minPosition])
            {
                minPosition = j;
            }
        }
        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }
}

SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);