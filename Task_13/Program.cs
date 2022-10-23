Console.WriteLine("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
int thirdDigit = GetThirdDigit(input);

int GetThirdNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

int GetThirdDigit(int number)
{
    int length = GetThirdNumber(number);
    int[] array = new int[length];

    for (int i = length - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    Console.WriteLine($"Третья цифра числа - {array[2]}");
    return 6;
}