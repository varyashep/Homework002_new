using static System.Console; 

WriteLine("Введите цифру, обозначающую день недели:");

int number = int.Parse(ReadLine()!);

if (number > 7)
{
    WriteLine("Такого дня недели не существует.");
}
else if (number == 6 || number == 7)
{
    WriteLine("Да, это выходной");
}
else
{
    WriteLine("Нет, это не выходной");
}