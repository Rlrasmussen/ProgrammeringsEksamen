namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 3, 4, 1, 2 };

            InsertionSort(myArray);

            foreach (int array in myArray)
            {
                Console.WriteLine("Insertion sort");
                Console.Write(array + " ");
            }

            BubbleSort(myArray);

            foreach (int array in myArray)
            {
                Console.WriteLine("Bubble sort");
                Console.WriteLine(array);
            }

            QuickSort(myArray, 0, myArray.Length);

            foreach (int array in myArray)
            {
                Console.WriteLine("Quick sort");
                Console.WriteLine(array);
            }
        }

        /// <summary>
        /// Insertion sort
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static void InsertionSort(int[] array)
        {
            int tmp; //Tempery value

            for (int i = 1; i < array.Length; i++)
            {
                tmp = array[i];

                while (i > 0 && tmp < array[i - 1])
                {
                    array[i] = array[i - 1];
                    i--;
                }

                array[i] = tmp;
            }
        }

        /// <summary>
        /// Bubble sort
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static void BubbleSort(int[] array)
        {
            //Temperary value
            int tmp;

            for (int i = 0; i < array.Length - 1; i++) //Repaets until no mere changes are made
            {
                for (int j = 0; j < array.Length - i - 1; j++) //Iterating through the items and swapping
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }

            //return sortArray;
        }

        /// <summary>
        /// Quick sort - collection the different part together to the fanil array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void QuickSort(int[] array, int start, int end)
        {
            //base case
            if (end <= start)
            {
                return;
            }

            //Calculation the pivot
            int pivot = Partition(array, start, end);
            //Sorten the part before and after the pivot
            QuickSort(array, start, pivot - 1); //Before pivot
            QuickSort(array, pivot + 1, end); //After pivot
        }

        /// <summary>
        /// Calculation the pivot and sorten the different parts of the array => part of the Quick sort method
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end - 1]; //The value of the pivot
            int i = start - 1; //Lokation of the pivot
            int tmp; //Tempery value

            for (int j = start; j <= end - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
            }
            i++;
            tmp = array[i];
            array[i] = array[end - 1];
            array[end - 1] = tmp;

            return i;
        }
    }
}
