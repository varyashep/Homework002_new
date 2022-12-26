using static System.Console;

WriteLine("Введите число:");
 
int number = int.Parse(ReadLine()!);
int third_digit;
if (number < 100)
{
    WriteLine("Третьей цифры нет.");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }
third_digit = number % 10;
Write("Третья цифра числа: ");
WriteLine(third_digit);
}