// Даны два действительных числа x и у. Вычислить их сумму, разность, произведение и частное 
double x = new Random().NextDouble();
double y = new Random().NextDouble();
double sum = x + y;
double raz = x - y;
double umn = x * y;
double del = x / y;
Console.WriteLine($"Какие числа мы вычисляем: x = {x}, y = {y}");
Console.WriteLine($"Сумма чисел {sum}");
Console.WriteLine($"Разница чисел {raz}");
Console.WriteLine($"Произведение чисел {umn}");
Console.WriteLine($"Частное чисел {del}");