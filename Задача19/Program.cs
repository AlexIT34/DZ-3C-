//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int numbersave = n;
int revnumber = 0;

while (n > 0)
{
    int dig = n % 10;
    revnumber = revnumber * 10 + dig;
    n = n / 10;
}
if (numbersave == revnumber)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");