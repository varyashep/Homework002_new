using static System.Console;

WriteLine("Введите трёхзначное число:");
int number = int.Parse(ReadLine()!);

int second_digit = (number / 10) % 10;

Write("Вторая цифра числа: ");
WriteLine(second_digit);