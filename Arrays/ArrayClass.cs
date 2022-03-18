using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class ArrayClass
    {
        public static int FindMin(int[] array)
        {
            int minElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
            }
            return minElement;
        }
        public static int FindMax(int[] array)
        {
            int maxElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
        public static int FindIndexOfMinElement(int[] array)
        {
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[minIndex] > array[i])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public static int FindIndexOfMaxElement(int[] array)
        {
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[maxIndex] < array[i])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int FindSumOfElementsWithOddIndexes(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        public static int[] Reverse(int[] array)
        {
            int[] result = Copy(array);
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = result[i];
                result[i] = result[result.Length - (i + 1)];
                result[result.Length - (i + 1)] = tmp;
            }
            return result;
        }
        public static int[] Copy(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }
        public static int[] CreateRandom(int lenght, int min = -100, int max = 100)
        {
            if (lenght < 0)
            {
                throw new Exception("lenght >= 0");
            }
            Random random = new Random();
            int[] array = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }

        public static void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }


        public static int FindNumberOfElementsWithOddIndex(int[] array)
        {
            int numberOffOdd = 0;
            if (array.Length == 1)
            {
                numberOffOdd = 0;
            }
            else
            {
                numberOffOdd = (array.Length) / 2;
            }

            return numberOffOdd;
        }

        public static int[] DoBubbleSortingInAscendingOrder(int [] array)
        {
            int[] result = Copy(array);
            int tmp = result[0];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        tmp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = tmp;
                    }
                }

            }
            return result;
        }
        //public static int[] DoInsertionSortingInDescendingOrder(int[] array)
        //{

       // }
    }
}
        
        
