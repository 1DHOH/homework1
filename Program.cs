using System;

public class SolvingProblems
{
    public static void Main(string[] args)
    {
        string[] lines = new string[11] { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"}; // ввод входных данных в массив строк.
        string[] ans = new string[lines.Length];//массив для найденных строк длинной <4.
        int anscnt = 0;//Количество найденных строк длинной <4.
        for (int i = 0; i < lines.Length; i++)//цикл нахождения строк длинной <4.
        {
            if (lines[i].Length <= 3)
            {
                ans[anscnt] = lines[i];
                anscnt++;
            }
        }
        for (int i = 0; i < ans.Length; i++)//цикл вывода строк длинной <4.
        {
            Console.Write($"{ans[i]} ");
        }
    }
}