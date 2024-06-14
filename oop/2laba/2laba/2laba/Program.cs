class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел в одномерном массиве:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        CreateOneDimensionalArray(n, arr);
        ShowArray(arr);

    }

    static void CreateOneDimensionalArray(int n, int[] arr)
    {
        
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(0, 21);
        }

    }

    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}