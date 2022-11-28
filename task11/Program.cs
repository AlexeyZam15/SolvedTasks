// В массиве хранятся цены на 10 видов мороженого. С помощью датчика
// случайных чисел заполнить массив целыми значениями, лежащими в диапазоне
// от 3 до 20 включительно. Определить порядковый номер самого дорогого
// мороженого.

void RandomArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}

void PrintArrayNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{i+1}. {arr[i]}");
    }
}

int IndexMax(int[] arr)
{
    int max = arr[0];
    int indexMax = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            indexMax = i;
        }
    }
    return indexMax;
}

int[] array = new int[10];
RandomArray(array, 3, 20);
Console.WriteLine("Цены на мороженое: ");
PrintArrayNumbers(array);
Console.WriteLine();

int numberMax = IndexMax(array) + 1;
Console.WriteLine($"Номер самого дорогого мороженого - {numberMax}");