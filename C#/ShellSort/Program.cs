using System;
using System.Collections.Generic;

class Shellsort {
    //Una funcion de utilidad para imprimir una matriz de tamaño n
    public static void displayArr(int[] imputArr) {
        foreach (int k in imputArr) {
            Console.Write(k + " ");
        }
        Console.WriteLine();
    }

    //Funcion para ordenar imputArr usando shellsort
    public int sort(int[] imputArr) {
        int size = imputArr.Length;
        //Comience con un espacio grande y luego reduzca su espacio
        int gapSize = size / 2;
        while (gapSize > 0) {
            //Estamos implementando una ordenacion por insercion con un espacio de tamaño especifico
            //Los primeros elementos de espacio de la matriz imputArr[0..gapSize-1]
            //Ya en orden, ahora tenemos que seguir agregando
            //un elemento mas hasta que la matriz este completamente ordenada
            for (int j = gapSize; j < size; j++) {
                int val = imputArr[j];
                int k = j;
                while (k >= gapSize && imputArr[k - gapSize] > val) {
                    imputArr[k] = imputArr[k - gapSize];
                    k = k - gapSize;
                }
                imputArr[k] = val;
            }
            gapSize = gapSize / 2;
        }
        return 0;
    }

    static void Main(string[] args) {
        int[] imputArr = { 36, 34, 43, 11, 15, 20, 28, 25 };
        Console.WriteLine("Antes de ser ordenados: ");
        Shellsort.displayArr(imputArr);
        Shellsort obj = new Shellsort();
        obj.sort(imputArr);
        Console.WriteLine("Arreglo despues de ser ordenados: ");
        Shellsort.displayArr(imputArr);
    }
}
