//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
bool one =true;
while(one)
{
    try
{
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = 0;
for(int i = 1;i <=n; i++)
{
    index=(int)Math.Pow(i,3);
if(i==n)Console.Write(index+".");
else
Console.Write(index+",");
}
one = false;
}
catch
{
    Console.WriteLine("Ошибка ввода попробуйте ещё раз: ");
}}
