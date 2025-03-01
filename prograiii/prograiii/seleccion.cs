using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class seleccion
{
    public static int BusquedaPorSeleccion(int[] array, int valor)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valor)
            {
                return i;
            }
        }
        return -1;
    }
}
