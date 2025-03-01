using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prograiii
{
    class binario
    {
        public static List<int> BusquedaBinaria(int[] arreglo, int valor)
        {
            List<int> indices = new List<int>();
            int inicio = 0;
            int fin = arreglo.Length - 1;

            while (inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;

                // Verificamos si el valor está en el medio
                if (arreglo[medio] == valor)
                {
                    indices.Add(medio);

                    //hacia la izquierda
                    int izquierda = medio - 1;
                    while (izquierda >= 0 && arreglo[izquierda] == valor)
                    {
                        indices.Add(izquierda);
                        izquierda--;
                    }

                    //hacia la derecha
                    int derecha = medio + 1;
                    while (derecha < arreglo.Length && arreglo[derecha] == valor)
                    {
                        indices.Add(derecha);
                        derecha++;
                    }

                    break;
                }

                // Si el valor es mayor, ignorar la mitad izquierda
                if (arreglo[medio] < valor)
                {
                    inicio = medio + 1;
                }
                // Si el valor es menor, ignorar la mitad derecha
                else
                {
                    fin = medio - 1;
                }
            }
            // Ordenamos los índices
            indices.Sort();
            return indices;
        }
    }
}
