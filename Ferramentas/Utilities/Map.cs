using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.Utilities
{
    static class Map
    {
        internal static int[] MapArray(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length != secondArray.Length) throw new Exception("Arrays de tamanhos diferentes");

            int size = firstArray.Length;

            int[] mappedArray = new int[size];

            for (int iter = 0; iter < size; iter++)
            {
                mappedArray[iter] = firstArray[iter] * secondArray[iter];
            }
            
            return mappedArray;
        }
    }
}
