using System;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            byte n = Convert.ToByte(Console.ReadLine());
            int[,] arr = new int[n,n];
            Input(arr, n);
            Out(arr, n);
            Sort(arr, n);
            Out(arr, n);

            Console.ReadKey(); 
        }

        static void Input(int[,] arr, byte n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = random.Next(10, 20);
                }
            }
        }
        static void Out(int [,]arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
           
        }
        static void Sort(int [,]arr, int n)
        {
            for (int h = 0; h < n*n; h++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i==n-1 && j==n-1)
                        {
                            break;
                        }
                        if (j==n-1)
                        {
                            if (arr[i+1,0]<arr[i,j])
                            {
                                int temp = arr[i + 1, 0];
                                arr[i + 1, 0] = arr[i, j];
                                arr[i, j] = temp;
                            }

                        }
                        else
                        {
                            if (arr[i, j + 1] < arr[i, j])
                            {
                                int temp = arr[i, j + 1];
                                arr[i, j + 1] = arr[i, j];
                                arr[i, j] = temp;
                            }
                        }
                    }
                }
            }
        }
    }
}
