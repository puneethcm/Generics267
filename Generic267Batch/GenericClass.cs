using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Generic267Batch
{
	public class GenericClass<T>
    {
        public T[] array;
        public GenericClass(T[] array)
        {
            this.array = array;
        }

        public void DeleteArray(T[] array, T deleteArray)
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
    }
}

