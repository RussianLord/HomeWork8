void HW1()
{
    Console.Clear();
    Console.WriteLine("Данная программа создаёт случайный двухмерный массив размером от 3x3 до 9x9 и сортирует его по строкам или столбцам...");
    Console.WriteLine("Нажмите ENTER, чтобы создать массив...");
    Console.ReadLine();
    Random random = new Random();
    int rows = random.Next(3, 10);
    int columns = random.Next(3, 10);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Нажмите Y для сортировки по столбцам или N для сортировки по строкам");
    ConsoleKeyInfo consoleKey = Console.ReadKey();
    Console.WriteLine();
    if(consoleKey.KeyChar == 'y')
    {
        SortColumns(numbers);
    }
    if(consoleKey.KeyChar == 'n')
    {
        SortRows(numbers); 
    }
    Console.WriteLine("Сортированный массив...");
    PrintArray(numbers);
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            numbers[i,j] = random.Next(-9, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortRows(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1) - 1;
    for(int i = 0; i < rows; i++)
    {  
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < columns; k++)
            {
                if(numbers[i, k] > numbers[i, k + 1]) (numbers[i, k], numbers[i, k + 1]) = (numbers[i, k + 1], numbers[i, k]);
            }           
        }
    }
}

void SortColumns(int[,] numbers)
{
    int rows = numbers.GetLength(0) - 1;
    int columns = numbers.GetLength(1);
    for(int j = 0; j < columns; j++)
    {  
        for(int i = 0; i < rows; i++)
        {
            for(int k = 0; k < rows; k++)
            {
                if(numbers[k, j] < numbers[k + 1, j]) (numbers[k, j], numbers[k + 1, j]) = (numbers[k + 1, j], numbers[k, j]);
            }
        }
    }
}



HW1();