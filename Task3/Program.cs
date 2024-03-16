using System.Text;
using System.Text.RegularExpressions;

namespace Task3;
//Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. В строке может быть несколько фрагментов, заключённых в фигурные скобки.
//Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
class Program
{
    public static string MyMethod(string input, char ignoreable, char continueable)
    {
        int i = 0;
        var sb = new StringBuilder();
        foreach (char c in input)
        {
            if (c == ignoreable)
                i++;
            else if (c == continueable)
                i--;
            else if (i == 0)
                sb.Append(c);
        }
        return sb.ToString();
    }

    static void Main()
    {
        string str = Console.ReadLine();
        string strA = MyMethod(str, '{', '}');
        Console.WriteLine(strA);
        Console.ReadKey();
    }
}

