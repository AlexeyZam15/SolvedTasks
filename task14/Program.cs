// Дан двумерный массив. Определить какие элементы повторяются в строке и их количество.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            // TODO: вывести индексы массива.
            // matrix[i, j] = i * 10 + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],3}{separatorElems}");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(endRow);
    }
}

void PrintArray(int[] arr, string beginRow, string separatorElems, string endRow)
{
    Console.Write(beginRow);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems}");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine(endRow);
}

int[,] RepeatedElementsMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] repeatedElemsMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = j + 1; k < columns; k++)
            {
                if (matrix[i, j] == matrix[i, k])
                {
                    repeatedElemsMatrix[i, j] = matrix[i, j];
                    repeatedElemsMatrix[i, k] = matrix[i, j];
                }
            }
        }
    }
    return repeatedElemsMatrix;
}

int[,] CountRepeatedElements(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    matrix = RepeatedElementsMatrix(matrix);
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        bool repeated = false;
        int temp = 0;
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] != temp && matrix[i, j] != 0)
            {
                for (int s = 0; s < columns; s++)
                {
                    if (matrix[i, j] == matrix[i, s] && j > s)
                    {
                        repeated = true;
                        break;
                    }
                    if (matrix[i, j] == matrix[i, s] && j < s)
                        repeated = false;
                }
                if (repeated != true)
                {
                    index++;
                    temp = matrix[i, j];
                }
            }
        }
    }
    int[,] elementsCount = new int[index, 3];
    index = 0;
    for (int i = 0; i < rows; i++)
    {
        bool repeated = false;
        int temp = 0;
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] != temp && matrix[i, j] != 0)
            {
                for (int s = 0; s < columns; s++)
                {
                    if (matrix[i, j] == matrix[i, s] && j > s)
                    {
                        repeated = true;
                        break;
                    }
                    if (matrix[i, j] == matrix[i, s] && j < s)
                        repeated = false;
                }
                if (repeated != true)
                {
                    elementsCount[index, 0] = matrix[i, j];
                    elementsCount[index, 2] = i;
                    for (int m = 0; m < columns; m++)
                    {
                        if (elementsCount[index, 0] == matrix[i, m])
                            elementsCount[index, 1]++;
                    }
                    index++;
                    temp = matrix[i, j];
                }
            }
        }
    }
    return elementsCount;
}

void PrintMatrixSpecial(int[,] matrix, string beginRow, string afterFirstRow, string afterSecondRow, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write($"{matrix[i, j],2}{afterFirstRow}");
            else if (j == 1)
                Console.Write($"{matrix[i, j],2}{afterSecondRow}");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine(endRow);
    }
}

int[,] matrix1 = CreateMatrixRndInt(5, 5, 1, 5);
PrintMatrix(matrix1, "", "", "");

// int[,] repeatedElementsMatrix = RepeatedElementsMatrix(matrix1);
// Console.WriteLine();
// PrintMatrix(repeatedElementsMatrix, "", "", "");

int[,] countRepeatedElements = CountRepeatedElements(matrix1);
Console.WriteLine();
PrintMatrixSpecial(countRepeatedElements, "Число ", " повторяется ", " раза в ", "-ой строке");