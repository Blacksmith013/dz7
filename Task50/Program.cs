void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}

int SerchPosition(int[,] array, int lin, int col)
{
    int result = array[lin, col];
    return result;
}

int ReadInputData()
{
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

Console.WriteLine("Введите число строк (m)");
int numberOfRows = ReadInputData();

Console.WriteLine("Введите число столбцов (n)");
int numberOfColumns = ReadInputData();

var array = CreateArrayWithRandomNumbers(numberOfColumns, numberOfRows);
PrintArray(array);

Console.WriteLine("Введите строку элемента (первая строка 0, вторая 1 и так далее...): ");
int line = ReadInputData();

Console.WriteLine("Введите колонку элемента (первая колонка 0, вторая 1 и так далее...): ");
int column = ReadInputData();


if (line > numberOfRows && column > numberOfColumns)
{
    Console.WriteLine("Введенные значения находятся за пределами массива");
    return;
}

var result = SerchPosition(array, line, column);
Console.WriteLine($"В строке {line} и колонке {column} массива находится число {result}");