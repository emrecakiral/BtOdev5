class main
{
    static void Main(String[] args)
    {
        int[] sirasizlar = { 100, 5, 50, 2, 10, 99, 8, 4, 2 };
        int[] siralanmis = Sirala(sirasizlar); // sırasızlar dizinin siralanmış halini siralnamış dizisine atar...
        foreach (var item in siralanmis)
            Console.WriteLine(item);
    }
    static int[] Sirala(int[] arr)
    {
        int[] sirali = new int[0];

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j + 1] >= arr[j])
                    continue;
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
        sirali = arr;
        return sirali;
    }
}