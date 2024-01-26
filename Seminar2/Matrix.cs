internal class Matrix
{
    private static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[num, num];
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                matrix[i, j] = (i + 1) * (j + 1);
                matrix[i, j] = (i + 1) * (j + 1);
            }
            Console.WriteLine();
        }
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}