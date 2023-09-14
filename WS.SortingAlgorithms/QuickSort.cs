namespace WS.SortingAlgorithms
{
    public static class QuickSort
    {
        public static void CreateQuickSort(int[] vector)
        {
            var swapper = true;
            var exchanges = 0;
            var comparisons = 0;
            var length = vector.Length;

            while (length > 1 || swapper)
            {
                if (length > 1)
                    length = (int)(length / 1.247330950103979);

                var i = 0;
                comparisons++;
                swapper = false;

                while (i + length < vector.Length)
                {
                    exchanges++;
                    if (vector[i].CompareTo(vector[i + length]) > 0)
                    {
                        (vector[i], vector[i + length]) = (vector[i + length], vector[i]);
                        swapper = true;
                    }
                    i++;
                }
            }
            Console.WriteLine($"Quick Sort Algorithm: comparison: {comparisons} exchanges: {exchanges}");
            foreach (var item in vector) Console.Write($"{item}, ");
            Console.WriteLine("\n\n");
        }
    }
}