class Programm
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Выберите: \n 1)Ввод чисел в массив с помощью ДСЧ \n 2)Ввод чисел в массив вручную");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в двумерном массиве:");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк в двумерном массиве:");
            int lines = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[lines, columns];
            if (inputSelection == 1)
            {
                CreateTwoDimensionalArray(columns, lines, arr);
            }
            else if (inputSelection == 2)
            {
                CreateTwoDimensionalArrayManually(columns, lines, arr);
            }
            else
            {
                Console.WriteLine("Неверное число, введите 1 или 2");
            }

            ShowTwoDimensionalArray(arr);

            int minValueInArray = FindMinimumValue(arr);

            int columnWhereMinValue = FindCollumnsWhereMinValue(arr, minValueInArray);
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели буквы, будьте впредь аккуратны");

        }


    }
    static int[,] CreateTwoDimensionalArray(int columns, int lines, int[,] arr) // создание двумерного массива с помощью ДСЧ
    {

        Random rnd = new Random();
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = rnd.Next(0, 21);
            }
        }
        return arr;
    }
    static int[,] CreateTwoDimensionalArrayManually(int columns, int lines, int[,] arr) // создание двумерного массива вручную
    {
        Console.WriteLine("Введите числа массива:");
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return arr;
    }

    static void ShowTwoDimensionalArray(int[,] arr) // вывод двумерного массива
    {
        Console.WriteLine("Массив:");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static int FindMinimumValue(int[,] arr) //нахождение минимального занчения в массиве
    {
        int one = 0;
        
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (one < arr[i, j])
                {
                    one = arr[i, j];
                }
            }
        }
        return one;
    }

    static int FindCollumnsWhereMinValue(int[,] arr, int min) //нахождение столбца в котором первый раз встречается минимальный элемент
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (min == arr[i, j])
                {
                    return j;
                } 
            }            
        }
        return 0;       
    }

   
}