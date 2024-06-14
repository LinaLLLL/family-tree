class Program
{
    static void Main(string[] args)
    {
        //1 задание
        Console.WriteLine("Введите количество чисел в одномерном массиве:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        CreateOneDimensionalArray(n, arr);
        ShowOneDimensionalArray(arr);
        Console.WriteLine("Введите номер элемента, который нужно удалить:");
        int numberToDelete = Convert.ToInt32(Console.ReadLine());
        ShowOneDimensionalArray(DeleteElementInOneDimensionalArray(numberToDelete, arr));

        //2 задание
        Console.WriteLine("Введите количество столбцов в двумерном массиве:");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество строк в двумерном массиве:");
        int lines = Convert.ToInt32(Console.ReadLine());
        int[,] arr2 = new int[columns,lines];

    }

    static int[] CreateOneDimensionalArray(int n, int[] arr)
    {
        
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(0, 21);
        }
        return arr;
    }

    static void ShowOneDimensionalArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static int[] DeleteElementInOneDimensionalArray(int n, int[] arr)
    {
        int[] arr2 = new int[arr.Length-1];
        for (int i = 0;i < n; i++)
        {
            arr2[i] = arr[i];
        }
        for (int i = n;i<arr.Length-1 ; i++)
        {
            arr2[i] = arr[i+1];
        }
        return arr2;
        
    }

    static int[,] CreateTwoDimensionalArray(int columns, int lines, int[,] arr)
    {

        Random rnd = new Random();
        for (int i = 0; i < columns; i++)
        {
            for(int j = 0; j < lines; j++)
            {
                arr[i,j] = rnd.Next(0, 21);
            }
        }
        return arr;
    }

    static void ShowTwoDimensionalArray(int columns, int lines, int[,] arr)
    {
        for(int i = 0; i < columns; i++)
        {
            for (int j = 0; j < lines; j++)
            {
                Console.Write(arr[i,j] + " ");
            }
        }
        Console.WriteLine();
    }
}