namespace Task1;
//Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
//Знаки препинания не используются. Найти самое длинное слово в строке.

class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("введите предложение");
        string str = Console.ReadLine();
        string[] array = str.Split();
        string max = array[0];
        foreach(string s in array)
        {
            if (s.Length>max.Length)
            {
                max = s;
            }
        }
        Console.WriteLine(max);
        Console.ReadKey();

    }
}

