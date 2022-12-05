// Создайте метод для обмена определенных элементов матрицы размера 3 х 4 

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
                Console.Write($"{matrix[i, j],4}{separatorElems}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(endRow);
    }
}

void StringToTwoNumbers(string str, out int rowIndex, out int columnIndex)
{
    string[] arrString = str.Split(',');
    rowIndex = Convert.ToInt32(arrString[0]);
    columnIndex = Convert.ToInt32(arrString[1]);
}

bool IndexMatrix(int[,] matrix, int rowIndex1, int columnIndex1)
{
    if (rowIndex1 < 0 || columnIndex1 < 0) return false;
    if (rowIndex1 >= matrix.GetLength(0) || columnIndex1 >= matrix.GetLength(1)) return false;
    return true;
}

void ReplaceMatrixElements(int[,] matrix, int rowIndex01, int columnIndex01, int rowIndex02, int columnIndex02)
{
    int temp = matrix[rowIndex01, columnIndex01];
    matrix[rowIndex01, columnIndex01] = matrix[rowIndex02, columnIndex02];
    matrix[rowIndex02, columnIndex02] = temp;
}

int rowSize = 3;
int columnSize = 4;

int[,] matrix1 = CreateMatrixRndInt(rowSize, columnSize, -9, 9);
PrintMatrix(matrix1, "", "", "");

int rowIndex1 = -1, columnIndex1 = -1, rowIndex2 = -1, columnIndex2 = 01;
bool indexMatrix1 = false, indexMatrix2 = false;
string numbersString1, numbersString2;

while (indexMatrix1 == false)
{
    Console.Write("Введите индексы строки и столбца для первого элемента, через запятую: ");
    numbersString1 = Console.ReadLine();
    StringToTwoNumbers(numbersString1, out rowIndex1, out columnIndex1);
    indexMatrix1 = IndexMatrix(matrix1, rowIndex1, columnIndex1);
    if (indexMatrix1 == false) Console.WriteLine("Таких индексов в матрице нет");
}

while (indexMatrix2 == false)
{
    Console.Write("Введите индексы строки и столбца для второго элемента, через запятую: ");
    numbersString2 = Console.ReadLine();
    StringToTwoNumbers(numbersString2, out rowIndex2, out columnIndex2);
    indexMatrix2 = IndexMatrix(matrix1, rowIndex2, columnIndex2);
    if (indexMatrix2 == false) Console.WriteLine("Таких индексов в матрице нет");
}

ReplaceMatrixElements(matrix1, rowIndex1, columnIndex1, rowIndex2, columnIndex2);
Console.WriteLine($"Элементы матрицы [{rowIndex1},{columnIndex1}] и [{rowIndex2},{columnIndex2}] обменялись местами");
PrintMatrix(matrix1, "", "", "");