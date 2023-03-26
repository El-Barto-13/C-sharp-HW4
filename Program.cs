// Home Work 4

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
System.Console.Write("Введиче число которое будет возводиться в степерь: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введиче степень числа: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

int result = Square(number, quadNum);
System.Console.WriteLine($"Результат полученного значения {result}");

int Square (int number, int quadNum)
{
    int Multiplier = number;

    for(int f = 1; f < quadNum; f++)
    {
        number = number * Multiplier; 
    }
    return number;
}
*/

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
System.Console.Write("Введиче число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountNumbers(number);
System.Console.WriteLine($"Результат суммы цифр в числе: {result}");

// через for
int CountNumbers(int num) //354 
{
    int sum;

    for (sum = 0; num > 0; num = num / 10)
    {
        sum += num % 10; // sum = sum + num % 10
    }
    return sum;
}
 */

/*
// или через while
int CountNumbers(int num) //354
{
    int sum = 0;
    while (num > 0) //->4 -> 5 -> 3
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
*/