//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число:");
int chislo = int.Parse(Console.ReadLine()!);
int result = 0;
if (chislo < 0)
{
    chislo = -chislo;
}
if (chislo / 100 >0)
{
    while (chislo > 999)
    {
    chislo = chislo / 10;
    }
    result = (chislo % 10);
    Console.WriteLine(result);
}
else {
    Console.WriteLine("третьей цифры нет");
}