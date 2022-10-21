/*
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7: ");
string userNumber = Console.ReadLine();
int dayNumber = int.Parse(userNumber);
if (dayNumber == 1) Console.WriteLine("Сегодня рабочий день, понедельник");
if (dayNumber == 2) Console.WriteLine("Сегодня рабочий день, вторник");
if (dayNumber == 3) Console.WriteLine("Сегодня рабочий день, среда");
if (dayNumber == 4) Console.WriteLine("Сегодня рабочий день, четверг");
if (dayNumber == 5) Console.WriteLine("Сегодня рабочий день, пятница");
if (dayNumber == 6) Console.WriteLine("Сегодня выходной  день, суббота, можно спать до 10");
if (dayNumber == 7) Console.WriteLine("Сегодня выходной день, воскресенье");