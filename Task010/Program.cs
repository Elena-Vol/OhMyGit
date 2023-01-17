/*  Напишите программу, которая принимает на вход трёхзначное число 
 и на выходе показывает вторую цифру этого числа. 
 Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
456 -> 5
782 -> 8
918 -> 1 */

int GetNumber (int num)
{
    int tenth = num / 10;
    int digit = tenth % 10;
    return digit;
}

Console.Write("Введите трехзначное число ");
int numder = Convert.ToInt32(Console.ReadLine());

if (numder > 99 && numder <1000)
{
    int midlDigit = GetNumber (numder);
Console.Write(midlDigit);
}
else Console.Write("Введено не корректное число");
