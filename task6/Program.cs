// Ввести любой символ и определить его порядковый номер, а также указать предыдущий и последующий символы. 
Console.WriteLine("Введите любой символ");
//char x = Console.ReadLine()[0];
char x = Console.ReadKey(true).KeyChar;
Console.WriteLine($"Введёный символ: {x}");
Console.WriteLine("Предыдущий символ: {0}", (char)(x-1));
Console.WriteLine("Следующий символ: {0}", (char)(x+1));