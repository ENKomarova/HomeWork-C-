/*Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNum ( int number)
{
    //int a = number / 10; int result = a%10; return result;
    return number / 10 % 10;
}

//int randNum = new Random().Next(100, 1000);
//int newNum = CutNum (randNum);

Console.WriteLine ("Enter a number from 100 to 999");
int number = Convert.ToInt32(Console.ReadLine());
int newNum = CutNum (number);
if ( number < 999 && number > 100)
Console.WriteLine ($"New version of a number {number} is  {newNum} ");
else
Console.WriteLine ("Incorrect number entry");

*/

/* Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input a  number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine( $"The third digit of a given number {anyNumber} is  {anyNumberText[2]} ");
}
else {
  Console.WriteLine("No third digit");
}

*/

/* Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(weekend) -> true");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Is not a day of the week");
  }
  else Console.WriteLine("(weekend) -> false");
}
Console.Write("Enter a number for the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

CheckingTheDayOfTheWeek(dayNumber);
*/