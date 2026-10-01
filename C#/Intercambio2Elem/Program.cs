using System;

class Program
{
    // Función para intercambiar dos elementos en el arreglo
    static void Swap(int[] a, int j, int k) // intercambia los elementos
    {
        int temp = a[j];
        a[j] = a[k];
        a[k] = temp; // intercambia los elementos
    }

    // Función para particionar el arreglo alrededor de un pivote
    static int Partition(int[] a, int l, int h)
    {
        int pivot = a[h];
        int i = l - 1;
        for (int j = l; j < h; j++)
        {
            if (a[j] <= pivot)
            {
                i += 1;
                Swap(a, i, j);
            }
        }
        Swap(a, i + 1, h);
        return i + 1;
    }

    // Implementación de la función QuickSort
    static void QckSort(int[] a, int l, int h) // función principal de QuickSort
    {
        if (l < h) // si el índice izquierdo es menor que el derecho
        {
            // pi es el índice de partición, regresa el índice del pivote
            int pi = Partition(a, l, h); // particiona el arreglo
            // llamadas recursivas para los elementos menores
            // y mayores o iguales a los elementos
            QckSort(a, l, pi - 1); // llamada recursiva para los elementos menores que el pivote
            QckSort(a, pi + 1, h); // llamada recursiva para los elementos mayores o iguales que el pivote
        }
    }

    // Código para probar la implementación de QuickSort
    static void Main() // punto de entrada del programa
    {
        int[] a = { 10, 7, 8, 9, 1, 5 }; // arreglo desordenado
        int size = a.Length; // tamaño del arreglo
        Console.WriteLine("El arreglo antes de ordenarlo: ");
        foreach (int v in a) // imprime el arreglo
        {
            Console.Write(v + " ");
        }
        Console.WriteLine(); // salto de línea
        QckSort(a, 0, size - 1);
        Console.WriteLine("El arreglo después de ordenarlo: ");
        foreach (int v in a) // imprime el arreglo ordenado
        {
            Console.Write(v + " ");
        }
    }
}
