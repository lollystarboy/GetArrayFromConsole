﻿namespace GetArrayFromConsole
{
    internal class Program
    {

            static void Main(string[] args)
        {
            var array = GetarrayFromConsole();
            var sortedarray = SortArray(array);
            


        }

        static int[] GetarrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static int[] SortArray(int[] result)
        { 

            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            
            return result;
        }
        
    }
} 
