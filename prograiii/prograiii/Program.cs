using prograiii;
using System;
using System.Collections.Generic;

class Program
{

    public static void Main(string[] args)
    {
        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Quicksort ");
            Console.WriteLine("2.Lineal-Search ");
            Console.WriteLine("3.Binary  ");
            Console.WriteLine("4.Seleccion");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

         

            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        ejecutarQuicksort();
                        break;
                    case 2:
                        ejecutarLineal();
                        break;
                    case 3:
                        ejecutarBinary();
                        break;
                    case 4:
                        ejecutarseleccion();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
           

            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        } while (option != 5);
    }

    static void ejecutarQuicksort()
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Entrada inválida. Regresando al menú...");
            return;
        }

        int[] arr;

        try
        {
            arr = Array.ConvertAll(input.Split(' '), int.Parse);
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Asegúrese de ingresar solo números.");
            return;
        }

        Console.WriteLine("\nArray original:");
        quicksort.PrintArray(arr);

        quicksort.QuickSortAlgo(arr, 0, arr.Length - 1);

        Console.WriteLine("\nArray ordenado:");
        quicksort.PrintArray(arr);
    }

    static void ejecutarLineal()
    {
        // Solicitar los elementos del arreglo en una sola línea con control de null
            Console.Write("Ingrese los elementos del arreglo separados por espacios: ");
        string? input = Console.ReadLine();

        // Si la entrada es null, asignamos una cadena vacía para evitar errores
        int[] arr = (input ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

        // Verificar si el arreglo está vacío
        if (arr.Length == 0)
        {
            Console.WriteLine("El arreglo está vacío. Intente nuevamente.");
            return;
        }
        // Solicitar el número a buscar
        Console.Write("Ingrese el número que desea buscar: ");
        if (!int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número.");
            return;
        }

        // Llamar al método de búsqueda lineal
        int result = lineal_search.LinearSearch(arr, x);

        // Mostrar el resultado
        if (result != -1)
        {
            Console.WriteLine($"El número {x} se encuentra en la posición {result}.");
        }
        else
        {
            Console.WriteLine($"El número {x} no está en el arreglo.");
        }
    }

    static void ejecutarBinary()
    {
        // Pedimos al usuario el tamaño del arreglo
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());
        int[] arreglo = new int[n];

        // Pedimos al usuario que elementos tendrá el arreglo
        Console.WriteLine("Ingrese los elementos del arreglo:");
        for (int i = 0; i < n; i++)
        {
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        // Pedimos al usuario el valor que necesita del arreglo
        Console.Write("Ingrese el valor a buscar: ");
        int valor = int.Parse(Console.ReadLine());

        // Ordenamos el arreglo para la búsqueda binaria
        Array.Sort(arreglo);
        Console.WriteLine("Arreglo ordenado para búsqueda binaria: " + string.Join(", ", arreglo));
        // Búsqueda Binaria
        List<int> resultadoBinario = binario.BusquedaBinaria(arreglo, valor);
        if (resultadoBinario.Any())
        {
            Console.WriteLine("Valor encontrado en los índices " + string.Join(", ", resultadoBinario));
        }
        else
        {
            Console.WriteLine(" Valor no encontrado.");
        }
    }


    static void ejecutarseleccion()
    {
        //Pedimos al usuario el tamaño del arreglo
            Console.Write("Ingrese el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        int[] arreglo = new int[n];

        // Pedimos al usuario que elementos tendrá el arreglo
        Console.WriteLine("Ingrese los elementos del arreglo:");
        for (int i = 0; i < n; i++)
        {
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        // Pedimos al usuario el valor que necesita del arreglo
        Console.Write("Ingrese el valor a buscar: ");
        int valor = int.Parse(Console.ReadLine());

        // Búsqueda por selección
        int indice = seleccion.BusquedaPorSeleccion(arreglo, valor);

        if (indice != -1)
        {
            Console.WriteLine("Búsqueda por selección: Valor encontrado en el índice " + indice);
        }
        else
        {
            Console.WriteLine("Búsqueda por selección: Valor no encontrado.");
        }
    } 
}
