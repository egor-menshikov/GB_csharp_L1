// Сортировка массива методом минмакса

// Дан массив
int[] arr = {1, 5 ,4, 3, 2, 6, 7, 1, 1};

// Метод вывода массива на экран
void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод упорядочивания
void SelectionSort(int[] array )
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length ; j++)              //ищем минимальный элемент
        {                                                        //
            if (array[j] < array[minPosition]) minPosition = j;  //
        }                                                        //
        int temp = array[i];                                     // свап
        array[i] = array[minPosition];                           //
        array[minPosition] = temp;                               //
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);