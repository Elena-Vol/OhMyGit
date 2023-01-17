/* Напишите программу, которая 
принимает на вход цифру, 
обозначающую день недели, и 
проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

string PrintDay(int number)
{
   if (number < 1 || number > 7 ) return "Введено некорректное число";
    else if (number == 1) return $"{number} - не является выходным днем";
    else if (number == 2) return $"{number} - не является выходным днем";
    else if (number == 3) return $"{number} - не является выходным днем";
    else if (number == 4) return $"{number} - не является выходным днем";
    else if (number == 5) return $"{number} - не является выходным днем";
    else if (number == 6) return $"{number} - да, является выходным днем";
    else return $"{number} - да, является выходным днем"; 
}

Console.Write("Введите число от 1 до 7  ");
int num = Convert.ToInt16(Console.ReadLine());

string day = PrintDay(num);
Console.Write(day);



