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
                if(numbers[i, k] < numbers[i, k + 1]) (numbers[i, k], numbers[i, k + 1]) = (numbers[i, k + 1], numbers[i, k]);
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

void HW2()
{
    Console.Clear();
    Console.WriteLine("Данная программа создаёт случайный двухмерный массив размером от 2x2 до 5x5 и сообщает номер строки с самой низкой суммой элементов строки...");
    Console.WriteLine("Нажмите ENTER, чтобы создать массив...");
    Console.ReadLine();
    Random random = new Random();
    int rows = random.Next(2, 6);
    int columns = random.Next(2, 6);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"В массиве {rows} строк и {columns} столбцов.");
    if(rows == columns) Console.WriteLine("Массив не является прямоугольным.");
    else
    {
        FillArray(numbers);
        PrintArray(numbers);
        CheckArray(numbers);
    }
}

void CheckArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int sum = 0;
    int[] sumarray = new int[rows];
    Console.WriteLine("Массив из сумма чисал двухмерного массива.");
    for(int i = 0; i < rows; i++)
    {
        sum = 0;
        for(int j = 0; j < columns; j++)
        {
           sum = sum + numbers[i,j];
           sumarray[i] = sum;
        }
        Console.WriteLine(sumarray[i] + "\t");
    }
    Console.WriteLine();
    int minElement = sumarray[0];
    int size = sumarray.Length;
    int minIndex = 1;
    for(int i = 1; i < size; i++)
    {
        if(minElement > sumarray[i])
        {    
            minElement = sumarray[i];
            minIndex = i + 1;
        }
    }
    Console.WriteLine($"Строка {minIndex} имеет наименьшую сумму элементов. Сумма элементов = {sumarray[minIndex - 1]}");
    
    
   
}

void HW3()
{
    Console.Clear();
    Console.WriteLine("Данная программа заполняет массив по спирали. Размер 4x4");
    Console.WriteLine("Нажмите ENTER, чтобы создать массив...");
    Console.ReadLine();
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"В массиве {rows} строк и {columns} столбцов.");
    FillRound(numbers);
    PrintArray(numbers);
}

void FillRound(int[,] numbers)
{
    int size = 4;
    int count = 0;
    for(int i = 0; i < size - 3; i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            count++;
            numbers[i, j] = count;
        }
    }
    for(int j = 3; j < size; j++)
    {
        for(int i = 1; i < numbers.GetLength(0); i++)
        {
            count++;
            numbers[i, j] = count;
        }
    }
    for(int i = 3; i < size; i++)
    {
        for(int j = 2; j >= 0; j--)
        {
            count++;
            numbers[i, j] = count;
        }
    }
    for(int j = 0; j < size - 3; j++)
    {
        for(int i = 2; i > 0; i--)
        {
            count++;
            numbers[i, j] = count;
        }
    }
    for(int i = 1; i <= size - 3; i++)
    {
        for(int j = 1; j < size - 1; j++)
        {
            count++;
            numbers[i, j] = count;
        }
    }
    for(int j = 2; j < size - 1; j++)
    {
        for(int i = 2; i < size - 1; i++)
        {
            count++;
            numbers[i, j] = count;
        }
    }
    for(int i = 2; i < size - 1; i++)
    {
        for(int j = 1; j > 0; j--)
        {
            count++;
            numbers[i, j] = count;
        }
    }
}
// HW1();
// HW2();
HW3();
