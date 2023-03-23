// string[,] table = new string[2, 5];



// table[1, 2] = "word";


// for (int rows = 0; rows < table.GetLength(0); rows++)
// {
//     for (int columns = 0; columns < table.GetLength(1); columns++)
//     {
//         Console.Write($" -{table[rows, columns]}- ");
//     }
//     Console.WriteLine(String.Empty);
// }

void PrintArray(int[,] matr)
{
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int col = 0; col < matr.GetLength(1); col++)
        {
            Console.Write($"{matr[row, col]} ");
        }
        Console.WriteLine(String.Empty);
    }
    Console.WriteLine(String.Empty);
}

void FillArray(int[,] matr)
{
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int col = 0; col < matr.GetLength(1); col++)
        {
            matr[row, col] = new Random().Next(0, 100);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
