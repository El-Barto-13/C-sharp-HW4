// Home Work 4

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 3,5 -> 243 (3⁵)
// 2,4 -> 16

/*
System.Console.Write("Введите число возводимое в степерь: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень числа: ");
int degreeNum = Convert.ToInt32(Console.ReadLine());

int result = Square(number, degreeNum);
Console.WriteLine($"Результат полученного значения {result}");

int Square (int number, int degreeNum)
{
    int Multiplier = number;

    for(int f = 1; f < degreeNum; f++)
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
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountNumbers(number);
Console.WriteLine($"Результат суммы цифр в числе: {result}");


// через while
/*
int CountNumbers(int num) 
{
    int sum = 0;
    while (num > 0) 
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
*/

// через for
/*
int CountNumbers(int num)
{
    int sum;

    for (sum = 0; num > 0; num = num / 10)
    {
        sum += num % 10; // sum = sum + num % 10
    }
    return sum;
}
 */


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1,2,5,7,19 -> [1,2,5,7,19]
// 6,1,33 -> [6,1,33]
/*
int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,9);
Console.Write(randomArray[i] + "");
}
*/




