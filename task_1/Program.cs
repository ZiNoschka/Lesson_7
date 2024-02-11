class Program
{
    static string GenerateNumberSequence(int M, int N)
    {
        if (M == N)
            return M.ToString();
    
        else
            return M + ", " + GenerateNumberSequence(M + 1, N);
    }

    static void Main(string[] args)
    {
        int M = 1; 
        int N = 25; 

        string result = GenerateNumberSequence(M, N);
        Console.WriteLine(result); 
    }
}