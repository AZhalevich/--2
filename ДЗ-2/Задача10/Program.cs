// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int chislo = int.Parse(Console.ReadLine()!);
int result = (chislo / 10) % 10;
if(chislo < 100 || chislo > 999){
    Console.WriteLine("Вы ввели не корректное число");
}
else{
    Console.WriteLine($"Вторая цифра введённого числа: {result}");
}