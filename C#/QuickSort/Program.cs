using System;
using System.Collections.Generic;

class Program
{
    // Quick Sort
    // Funcion para intercambiar dos elementos del arreglo
    static void Swap(int[] a, int i, int j)
    {
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }

    // Funcion para hacer la particion del arreglo
    static int Partition(int[] a, int l, int h)
    {
        //selecciona el elemento pivote
        int pvt = a[h];
        //j es el indice de los elementos menores
        //pivote y tambien indica la posicion correcta del pivote hasta el momento
        int j = l - 1;
        //Recorre a[l..h-1] y mueve todos los elementos menores
        //al lado izq del pivote
        //elementos de l a j son mas pequeños despues de cada iteracion
        for (int k = l; k < h; k++) //recorre el arrglo
        {
            //si el elemento actual al pivote
            if (a[k] < pvt) //compara el lemento actual con el pivote
            {
                j += 1; //incrementa el indice de los elementos mas pequeños
                Swap(a, j, k); //intercambia los elementos
            }
        }
        //mover el pivote despues de los elementos mas pequeños
        //devolverlo a su posicion
        Swap(a, j + 1, h); //intercambia el pivote con el elemento siguiente al ulrimo elemento mas pequeño
        return j + 1; //devuleve el indice del pivote
    }
}