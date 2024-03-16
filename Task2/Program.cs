using System.Linq;

namespace Task2;
//Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
//Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
//(пример палиндрома – «А роза упала на лапу Азора»).

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение");
        string str0 = Console.ReadLine();
        string[] array = (str0.ToLower()).Split();
        string str = String.Join("",array);
        string str2 = "";
        foreach (char c in str)
        {
            str2 = c + str2;
        }

        if (str==str2)
        {
            Console.WriteLine("Строка является палиндромом");
        }

        else
            Console.WriteLine("Строка не является палиндромом");

        Console.ReadKey();
    }
}

