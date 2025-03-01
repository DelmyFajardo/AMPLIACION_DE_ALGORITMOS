﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prograiii
{
    internal class quicksort
    {
        // Método principal que implementa el algoritmo QuickSort
        public static void QuickSortAlgo(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                Console.WriteLine($"Pivote seleccionado: {arr[pi]} en la posición {pi}");
                Console.WriteLine("Estado del array después de la partición:");
                PrintArray(arr);

                QuickSortAlgo(arr, low, pi - 1);
                QuickSortAlgo(arr, pi + 1, high);
            }
        }

        // Método que realiza la partición del array
        public static int Partition(int[] arr, int low, int high)
        {
            //Aquí puede ser el mas alto, el mas bajo, el punto medio o random.
            int pivot = arr[high];
            Console.WriteLine($"\nIniciando partición con pivote {pivot} en la posición {high}");

            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                    Console.WriteLine($"Intercambio: {arr[i]} <-> {arr[j]}");
                    PrintArray(arr);
                }
            }

            Swap(arr, i + 1, high);
            Console.WriteLine($"Colocando pivote {arr[i + 1]} en su posición final:");
            PrintArray(arr);

            return i + 1;
        }

        // Método para intercambiar dos elementos en el array
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // Método para imprimir el array en consola
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}