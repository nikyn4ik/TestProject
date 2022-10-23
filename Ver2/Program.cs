using System;

namespace Ver2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 88, 199, 98 };
            Bubble(arr);
        }

        public static void Bubble(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    Console.Write(array[i]);
                else
                    Console.Write(array[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
