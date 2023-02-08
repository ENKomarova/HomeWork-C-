/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.


int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,999);
    }
    return array;
}
int EvenNum(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++) if(array[i] % 2 == 0) counter++;
    return counter;
}
void WriteArray( int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
    Console.WriteLine();
}
Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());
int[] newArr = CreateRandomArray(number);
WriteArray(newArr);
Console.WriteLine($"Even numbers quantity in array = {EvenNum(newArr)}");
*/
/*Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue+1);
    }
    return array;
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
    Console.WriteLine();
}

int SumOfEvenPosition(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i = i + 2)
        sum += array[i];
    return sum;
}

Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int min = Convert.ToInt16(Console.ReadLine());
Console.Write("Input maximum value: ");
int max = Convert.ToInt16(Console.ReadLine());
int[] newArray = CreateRandomArray(number,min,max);
WriteArray(newArray);

Console.WriteLine($"Sum number of even position in array {newArray} is {SumOfEvenPosition(newArray)}");
*/


/*Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        //array[i] = new Random().Next((int)minValue, (int)maxValue+1) ; // целые числа
        array[i] = new Random().Next((int)minValue, (int)maxValue+1) + rnd.NextDouble(); // десятичная дробь
    }
    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i]+"  ");
    Console.WriteLine();
}

double Distance(double[] array)
{
    double maxi = array[0];
    double mini = array[0];
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i] > maxi) 
        {
            maxi = array[i];
        }
        else if(array[i] < mini) mini = array[i];
    }
    return maxi - mini;
}

Console.Write("Input number of array elements: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maximum value: ");
double max = Convert.ToDouble(Console.ReadLine());

double[] newArr = CreateRandomArray(number,min,max);
WriteArray(newArr);

Console.WriteLine($"разница между между максимальным  и минимальным элементами: {Distance(newArr)}");
*/
