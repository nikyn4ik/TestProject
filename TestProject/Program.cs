namespace TestProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 88, 199, 98 };
            Bubble(arr);
        }

        public static void Bubble(int[] Array)
        {
            int temp;

            for (int i = 0; i < Array.Length; i++)
            {
                bool ordered = true;

                for (int j = Array.Length - 1; j > i; j--)
                {
                    if (Array[j - 1] > Array[j])
                    {
                        ordered = false;

                        temp = Array[j - 1];
                        Array[j - 1] = Array[j];
                        Array[j] = temp;
                    }
                }
                if (ordered)
                    break;
            }

            for (int k = 0; k < Array.Length; k++)
            {
                if (k == Array.Length - 1)
                    Console.Write(Array[k]);
                else
                    Console.Write(Array[k] + ", ");
            }
        }
    }
}