int number = GetRandomNumber(100, 1000);
Console.WriteLine(number);

int result = SecondFigure(number);
Console.WriteLine(result);

int GetRandomNumber(int minValue, int maxValue) // int указывает на тип возвращаемых данных, GRN - название метода (названия начинаются с больших букв), в скобках указываем парамерты метода
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue); // вложили параметры внутрь, можем извне их задавать
    return randomNumber;
}

int SecondFigure(int number)
{
    int first = number % 100;
    int second = first % 10;
    int result = (first - second) / 10;
    return result;
}