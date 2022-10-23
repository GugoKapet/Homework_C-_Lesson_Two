// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.WriteLine("введите два числа: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());

// bool result = CheckSquare(A, B);
// if (result)
// {
//     Console.WriteLine("является корнем");
// }
// else 
// {
//     Console.WriteLine("не является корнем");
// }

// bool CheckSquare(int firstNumber, int secondNumber)
// {
//     int square1 = firstNumber * firstNumber;
//     int square2 = secondNumber * secondNumber;

//     return square1 == secondNumber | square2 == firstNumber;
// }

Console.WriteLine("Введите цифру: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());


if (dayNumber == 6 | dayNumber == 7)
{
    Console.WriteLine("Выходной день");
}
else 
    if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Данного значения для недели не существует");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
