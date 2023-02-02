/* Задача 1.
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

int Funkt(int numA, int numB)
{
    int result = 1;
for(int current = 1; current <= numB; current++)
{
result = result * numA;
}
return result;
}
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int GetFunkt = Funkt(numA, numB);
Console.WriteLine($"вывод числа {numA} в степень {numB} будет {GetFunkt}");
*/

/* Задача 2.
 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

int SumNumber (int numberN)
{
    int length = Convert.ToString(numberN).Length;
    int a = 0;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        a = numberN - numberN % 10;
        sum = sum + (numberN - a);
        numberN = numberN / 10;
    }
    return sum;
}
Console.Write("input a number:  ");
int numN = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(numN);
Console.WriteLine($"Сумма цифр числа {numN} равна {sumNumber}");
*/

/* Задача 3.
Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Num {i + 1} : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}
void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length-1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}]");
    }
    Console.WriteLine();
}
Console.Write("Введите размер массива = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите элементы массива {size} : ");
int[] array = CreateArray(size);
ShowArray(array);
*/
