class Program
{
    static void Main(string[] args)
    {
        int[] myArray = GenerateArray(-1, 157);

        PrintReverse(myArray, myArray.Length - 1);
    }

    static void PrintReverse(int[] arr, int index)
    {
        if (index < 0)
            return;

        Console.WriteLine(arr[index]);
        PrintReverse(arr, index - 1);
    }

    static int[] GenerateArray(int start, int end)
    {
        if (start > end)
            return new int[0]; 

        int[] arr = GenerateArray(start, end - 1); 
        Array.Resize(ref arr, arr.Length + 1); 
        arr[arr.Length - 1] = end; 
        return arr;
    }
}
