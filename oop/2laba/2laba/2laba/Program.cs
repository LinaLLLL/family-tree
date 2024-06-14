using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        
        
        try
        {
            //1 задание
            /*
            Console.WriteLine("Выберите: \n 1)Ввод чисел в массив с помощью ДСЧ \n 2)Ввод чисел в массив вручную");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество чисел в одномерном массиве:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            if (inputSelection == 1)
            {
                CreateOneDimensionalArray(n, arr);
            }
            else if (inputSelection == 2)
            {
                CreateOneDimensionalArrayManually(n, arr);
            }
            else
            {
                Console.WriteLine("Неверное число, введите 1 или 2");
            }
            ShowOneDimensionalArray(arr);
            Console.WriteLine("Введите номер элемента, который нужно удалить:");
            int numberToDelete = Convert.ToInt32(Console.ReadLine());
            int[] res = DeleteElementInOneDimensionalArray(numberToDelete, arr);
            if(res!= null)
            {
                ShowOneDimensionalArray(res);
            }
            else
            {
                Console.WriteLine("Элемента с таким номером нет в массиве");
            }
            */
            

            //2 задание
            /*
            Console.WriteLine("Выберите: \n 1)Ввод чисел в массив с помощью ДСЧ \n 2)Ввод чисел в массив вручную");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в двумерном массиве:");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк в двумерном массиве:");
            int lines = Convert.ToInt32(Console.ReadLine());
            int[,] arr2 = new int[lines,columns];
            if (inputSelection == 1)
            {
                CreateTwoDimensionalArray(columns, lines, arr2);
            }
            else if (inputSelection == 2)
            {
                CreateTwoDimensionalArrayManually(columns, lines, arr2);
            }
            else
            {
                Console.WriteLine("Неверное число, введите 1 или 2");
            }
            ShowTwoDimensionalArray(arr2);
            ShowTwoDimensionalArray(AddLinesInTwoDimensionaArray(columns, lines, arr2));
            */


            //3 задание
            
            Console.WriteLine("Выберите: \n 1)Ввод чисел в массив с помощью ДСЧ \n 2)Ввод чисел в массив вручную");
            int inputSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк в рваном массиве:");
            int linesInSteppedArray = Convert.ToInt32(Console.ReadLine());
            int[][] arr3 = new int[linesInSteppedArray][];
            if (inputSelection == 1)
            {
                CreateSteppedArray(linesInSteppedArray, arr3);
            }
            else if (inputSelection == 2)
            {
                CreateSteppedArrayManually(linesInSteppedArray, arr3);
            }
            else
            {
                Console.WriteLine("Неверное число, введите 1 или 2");
            }         
            ShowSteppedArray(arr3);
            Console.WriteLine("Введите номер строки, после которой остальные строки удалятся:");
            int lineNumber = Convert.ToInt32(Console.ReadLine());
            int[][] res = DeleteLinesInSteppedArray(lineNumber, arr3);
            if (res != null)
            {
                ShowSteppedArray(res);
            }
            else
            {
                Console.WriteLine("Строки с таким номером нет в массиве");
            }
            
        }
        catch (FormatException)
        {
            Console.WriteLine("Вы ввели буквы, будьте впредь аккуратны");
            
        }
       
    }
    //1 задание
    static int[] CreateOneDimensionalArray(int n, int[] arr) // создание массива с помощью ДСЧ
    {
        
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(0, 21);
        }
        return arr;
    }

    static int[] CreateOneDimensionalArrayManually(int n, int[] arr) // создание массива вручную
    {
        Console.WriteLine("Введите числа массива:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }
    static void ShowOneDimensionalArray(int[] array) // вывод массива
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static int[] DeleteElementInOneDimensionalArray(int n, int[] arr) // удаление элемента в массиве
    {
        if (n < arr.Length)
        {
            int[] arr2 = new int[arr.Length - 1];
            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr[i];
            }
            for (int i = n; i < arr.Length - 1; i++)
            {
                arr2[i] = arr[i + 1];
            }
            return arr2;
        }
        else
        {
            return null;
            
        }
    }
    //2 задание
    static int[,] CreateTwoDimensionalArray(int columns, int lines, int[,] arr) // создание двумерного массива
    {

        Random rnd = new Random();
        for (int i = 0; i < lines; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                arr[i,j] = rnd.Next(0, 21);
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
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static int[,] AddLinesInTwoDimensionaArray(int columns, int lines, int[,] arr) // добавление строки в начало матрицы
    {
        Random rnd = new Random();
        int[,] arr2 = new int[lines + 1, columns];
        for (int i = 0; i <1; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr2[i, j] = rnd.Next(0, 21);
            }
        }
        for (int i = 1; i <= lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr2[i, j] = arr[i-1,j];
            }
        }
        return arr2;
    }

    //3 задание
    static int[][] CreateSteppedArray(int lines, int[][] arr) // создание рваного массива
    {
        Random rnd = new Random();
        
        for(int i=0; i<lines; i++)
        {
            
            arr[i] = new int[rnd.Next(2, 6)];
        }
        for (int i = 0; i < lines; i++)
        {
            
            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = rnd.Next(1, 15);
            }
        }
        return arr;
    }

    static int[][] CreateSteppedArrayManually(int lines, int[][] arr) // создание рваного массива вручную
    {

        Console.WriteLine("Введите количество чисел в строке:");
        for (int i = 0; i < lines; i++)
        {
            arr[i] = new int[Convert.ToInt32(Console.ReadLine())];
        }
        Console.WriteLine("Введите числа массива:");
        for (int i = 0; i < lines; i++)
        {

            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return arr;
    }
    static void ShowSteppedArray(int[][] arr) // вывод рваного массива
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static int[][] DeleteLinesInSteppedArray(int line, int[][] arr) // удаление строк в рваном массиве после заданной строки
    {
        if (line < arr.GetLength(0))
        {
            int[][] arr2 = new int[line][];
            for (int i = 0; i < line; i++)
            {
                arr2[i] = new int[arr[i].Length];
            }
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr2[i][j] = arr[i][j];
                }
            }
            return arr2;
        }
        else
        {
            return null;
        }
    }

       

}