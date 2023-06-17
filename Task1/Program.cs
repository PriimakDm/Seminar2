// На вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("input a three-digit number: ");
int namber = Convert.ToInt32(Console.ReadLine());
if (namber < 99 || namber > 999)
{
    Console.WriteLine("Error");
}
else
{
    int digit = ((namber % 100) / 10);
    Console.WriteLine("second digit: ");
    Console.Write(digit);
}