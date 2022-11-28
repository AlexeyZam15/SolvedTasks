// За каждый месяц банк начисляет к сумме вклада 7% от суммы.
// Напишите консольную программу, в которую пользователь вводит сумму вклада
// и количество месяцев.
// А банк вычисляет конечную сумму вклада с учётом начисления процентов 
// за каждый месяц.

// Для вычисления суммы с учётом процентов используйте цикл for.
// Для ввода суммы вклада используйте
// выражение Convert.ToDecimal(Console.ReadLine());
// (сумма вкладов будет представлять тип decimal)

decimal amount = -1;
while (amount < 1)
{
Console.Write("Введите сумму вклада: ");
amount = Convert.ToDecimal(Console.ReadLine());
if (amount < 0) Console.WriteLine("Введены неверные данные");
}

int month = -1;
while (month < 1 || month > 12)
{
Console.Write("Введите длительность вклада в месяцах: ");
month = Convert.ToInt32(Console.ReadLine());
if (month < 1 || month > 12) Console.WriteLine("Введены неверные данные");
}

int percent = 7;

decimal Deposit(decimal amount1, int month1, int percent1)
{
    for (int i = 1; i <= month1; i++)
    {
        amount1 += amount1 * percent1 / 100;
        Console.WriteLine(amount1);
    }
    return amount1;
}

decimal deposit = Deposit(amount, month, percent);
Console.WriteLine($"Конечная сумма вклада по истечении {month} месяцев будет равна {deposit}");