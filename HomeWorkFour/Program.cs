/* Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
bool Palindrome(int num)
{
    int refNum = 0;

    int newnum = num;
    while (num > 0)
    {
        refNum = refNum * 10 + num % 10 ;
        num = num / 10;
    }
    return refNum == newnum;
}
Console.Write ("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (Palindrome(numN))
Console.WriteLine($"Число {numN} является палиндромом");
else Console.WriteLine($"Число {numN} не является палиндромом");
*/


/* Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

double model (double xPos1, double yPos1,double zPos1, double xPos2, double yPos2, double zPos2)
{
return Math.Sqrt(Math.Pow(xPos1 - xPos2,2) +  Math.Pow(yPos1 - yPos2,2) + Math.Pow(zPos1 - zPos2,2));
}

Console.Write("Введите координату точки х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату точки y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату точки z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату точки х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату точки y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату точки z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(model(x1, y1, z1, x2, y2, z2));
*/


/*Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void Cube (int N)
{
    int count = 1;
    while (count <= N)
    {
    int cub = count * count * count;
    count++;
    Console.WriteLine(cub);
    }
}
Console.Write("Введите число N:  ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов от 1 до {numN}");
Cube(numN);

*/