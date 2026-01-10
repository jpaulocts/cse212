public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int cont1 = 0;
        int cont2 = 0;
        int i = 0;
        int[] numbers = new int[select.Length];

        foreach (int numero in select)
        {
            if (numero == 1)
            {
                numbers[i] = list1[cont1];
                cont1++;
            }
            else
            {
                numbers[i] = list2[cont2];
                cont2++;
            }

            i++;
        }
        return numbers;
    }
}