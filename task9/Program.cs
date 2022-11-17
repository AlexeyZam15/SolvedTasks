// Найти максимальную цифру из рандомного трехзначного числа используя метод 
int number = new Random().Next(100, 999);
Console.WriteLine($"Случайное число: {number}");



int Max(int number1)
{
    int numb1 = number / 100;
    int numb2 = number % 100 / 10;
    int numb3 = number % 10;
    int max = numb1;
    max = numb2 > max ? numb2 : max;
    max = numb3 > max ? numb3 : max;
    return max;
}

Console.WriteLine($"Максимальная цифра: {Max(number)}");