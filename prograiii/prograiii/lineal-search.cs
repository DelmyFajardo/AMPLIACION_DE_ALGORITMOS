using System;
using System.Linq;




    class lineal_search
    {
       public  static int LinearSearch(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i; // Retorna la posición si encuentra el elemento
                }
            }
            return -1; // Retorna -1 si no lo encuentra
        }

      
    }

