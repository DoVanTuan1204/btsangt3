using System;


namespace btđiemanh10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max,solanxuathien;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }

            int n = array.Length;
            // tang dan
            Console.WriteLine("\n tang dan :");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
               
            for (int i = 0; i < n; i++)
            {
                Console.Write( array[i] + " ");
            }


            //giam dan
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n giam dan :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\ngia tri lon nhat : " +max);
            Console.WriteLine("gia tri nho nhat : " + min);
        }
        

    }
}
