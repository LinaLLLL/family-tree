using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

class Programm
{
    // в другие перемменный ввести первое и последнее слово, из основной удалить их и потом сложить как надо
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите строку:");
            string string1 = Console.ReadLine();

            if (string1 != null) // проверяет пустая ли строка
            {
                string1.TrimStart(); // удаляет пробелы в начале
                string1.TrimEnd(); // удаляет пробелы в конце
            }
            else
            {
                Console.WriteLine("Вы ввели пустую строку");
            }
            string result = ChangeLastAndFirstWord(string1);
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Вы ввели пустую строку");
        }

    }

    static string ChangeLastAndFirstWord(string string1)
    {
        int indexFirstSpace = 0;
        int indexLastSpace = 0;
        for (int i = 0; i < string1.Length; i++) //находит индекс первого пробела
        {
            if(string1[i] == ' ' || string1[i] == ',' || string1[i] == '.' || string1[i] == ':' || string1[i] == ';')
            {
                indexFirstSpace = i;
                break;
            }
        }
        for (int i = string1.Length-1; i > 0; i--) // находит индекс последнего пробела
        {
            if (string1[i] == ' ' || string1[i] == ',' || string1[i] == '.' || string1[i] == ':' || string1[i] == ';')
            {
                indexLastSpace = i;
                break;
            }
        }

        string firstWord = string1.Substring(0, indexFirstSpace);
        string lastWord = string1.Substring(indexLastSpace+1);
        string mainString = string1.Substring(indexFirstSpace, string1.Length- firstWord.Length - lastWord.Length);
        mainString = mainString.Insert(0, lastWord);
        mainString = mainString.Insert(mainString.Length, firstWord);
        return mainString;
    }

    
}