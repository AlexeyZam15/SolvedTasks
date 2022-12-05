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
    int[,] array = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(0); k++)
            {
                if (matrix[i, j] == matrix[i, k])
                {
                    array[i, j] = matrix[i, j];
                    array[i, k] = matrix[i, j];
                }
            }
        }
    }
    return array;
}

int[,] CountRepeatedElements(int[,] matrix)
{
    int[,] elementsCount = new int[matrix.GetLength(0) * 2, 3];
    int[] tempArray = new int[matrix.GetLength(1)];
    int index = 0;
    int repeated = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempArray[j] = matrix[i, j];
        }
        for (int k = 0; k < tempArray.Length; k++)
        {
            if (tempArray[k] != temp && tempArray[k] != 0)
            {
                for (int s = 0; s < tempArray.Length; s++)
                {
                    if (tempArray[k] == tempArray[s] && k > s)
                        repeated = 1;
                    if (tempArray[k] == tempArray[s] && k < s)
                        repeated = 0;
                }
                if (repeated == 0)
                {
                    elementsCount[index, 0] = tempArray[k];
                    elementsCount[index, 2] = i;
                    for (int m = 0; m < tempArray.Length; m++)
                    {
                        if (elementsCount[index, 0] == tempArray[m])
                            elementsCount[index, 1]++;
                    }
                    index++;
                    temp = tempArray[k];
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
            if (j ==  0)
                Console.Write($"{matrix[i, j],2}{afterFirstRow}");
            else if (j ==  1)
                Console.Write($"{matrix[i, j],2}{afterSecondRow}");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine(endRow);
    }
}

int[,] matrix1 = CreateMatrixRndInt(5, 5, 1, 5);
PrintMatrix(matrix1, "", "", "");

int[,] repeatedElementsMatrix = RepeatedElementsMatrix(matrix1);
// Console.WriteLine();
// PrintMatrix(repeatedElementsMatrix, "", "", "");

int[,] countRepeatedElements = CountRepeatedElements(repeatedElementsMatrix);
Console.WriteLine();
PrintMatrixSpecial(countRepeatedElements, "Число "," повторяется ", " раза в ", "-ой строке");