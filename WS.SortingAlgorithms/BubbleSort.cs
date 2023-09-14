namespace WS.SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void CreateBubbleSort(int[] vector)
        {
            var exchanges = 0;
            var comparisons = 0;
            
            for (var i = vector.Length - 1; i >= 1; i--)
            {
                comparisons++;
                for (var j = 0; j < i; j++)
                {
                    exchanges++;
                    if (vector[j] > vector[j + 1])
                        (vector[j], vector[j + 1]) = (vector[j + 1], vector[j]);
                }
            }
            Console.WriteLine($"Bubble Sort Algorithm: comparison: {comparisons} exchanges: {exchanges}");
            foreach (var item in vector) Console.Write($"{item}, ");
            Console.WriteLine("\n\n");
        }
    }
}

