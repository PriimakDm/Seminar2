// Выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("input number: ");
int namber = Convert.ToInt32(Console.ReadLine());
int div = 10;
int prob = (namber / 10);
int rem = (namber % div);
if (prob < 10)
{
    Console.WriteLine("The third digit is missing");
}
if (namber > 99 && namber < 1000)
{
Console.WriteLine("The third digit is  ");
Console.WriteLine(rem);
}