// Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Press Inter");
ConsoleKey key = Console.ReadKey().Key;
if (key == ConsoleKey.Enter) {
int day = new Random().Next(1, 7);
if (day == 6 || day == 7)
{
    Console.WriteLine(day);
    Console.WriteLine("Day off");
}
else {
    Console.WriteLine(day);
    Console.WriteLine("Weekday");
}
}
   