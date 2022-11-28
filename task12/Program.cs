// В одномерном массиве хранится информация о зарплате 15 человек,
// работающих в отделе. Составить программу для определения:
// а) итоговой суммы по всему отделу;
// б) порядкового номера человека, получившего наименьшую зарплату;
// в) средней зарплаты по отделу

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
        Console.WriteLine($"{i + 1}. {arr[i]}");
    }
}

int SumArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

int IndexMin(int[] arr)
{
    int min = arr[0];
    int indexMin = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            indexMin = i;
        }
    }
    return indexMin;
}

int[] array = new int[15];
RandomArray(array, 20000, 30000);

Console.WriteLine("Зарплаты сотрудников:");
PrintArrayNumbers(array);

int totalSum = SumArray(array);
Console.WriteLine($"Итоговая сумма всех сотрудников по отделу: {totalSum}");

int numberMin = IndexMin(array) + 1;
Console.WriteLine($"Порядковый номер человека, получившего наименьшую зарплату - {numberMin}");

int average = totalSum / array.Length;
Console.WriteLine($"Средняя зарплата по отделу = {average}");