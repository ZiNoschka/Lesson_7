class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два неотрицательных числа m и n через пробел:");
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != 2)
        {
            Console.WriteLine("Некорректный ввод. Введите два неотрицательных числа через пробел.");
            return;
        }

        int m, n;
        if (!int.TryParse(input[0], out m) || !int.TryParse(input[1], out n) || m < 0 || n < 0)
        {
            Console.WriteLine("Числа должны быть неотрицательными.");
            return;
        }

        int result = Ackermann(m, n);
        Console.WriteLine("Значение функции Аккермана для m=" + m + " и n=" + n + " равно " + result);
    }
}
