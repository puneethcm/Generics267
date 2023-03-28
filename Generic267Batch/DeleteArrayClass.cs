using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Generic267Batch
{
	public class DeleteArrayClass
	{
		public static void DeleteIntArrayMethod(int[] arr, int delete)
		{
            int k = 0;
            int[] result = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach (int j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static void DeletedDoubleArrayMethod(double[] doubleArr, double doubleDelete)
        {
            int k = 0;
            double[] result = new double[doubleArr.Length - 1];

            for (int i = 0; i < doubleArr.Length; i++)
            {
                if (doubleDelete != doubleArr[i])
                {
                    result[k] = doubleArr[i];
                    k++;
                }
            }
            foreach (double j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static void DeletedCharArrayMethod(char[] charArr, char charDelete)
        {
            int k = 0;
            char[] result = new char[charArr.Length - 1];

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charDelete != charArr[i])
                {
                    result[k] = charArr[i];
                    k++;
                }
            }
            foreach (char j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static void DeleteGenericMethod<T>(T[] array, T deleteArray)
        {
            int k = 0;
            T[] result = new T[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (!deleteArray.Equals(array[i]))
                {

                    result[k] = array[i];
                    k++;
                }
            }
            foreach (T j in result)
            {
                Console.Write(j + " ");
            }
        }

        public static void Display<T>(T[] array)
        {
            Console.WriteLine("\nDisplaying values");
            foreach (T elements in array)
            {
                Console.Write(elements + " ");
            }

        }
    }
}

