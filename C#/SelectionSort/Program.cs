using System;

class Program {
    static void selection(int[] a) { // funcion para implementar el algoritmo de selección
        for (int i = 0; i < a.Length; i++) { // recorre todo el arreglo
            int small = i; // indice del elemento más pequeño
            for (int j = i + 1; j < a.Length; j++) { // encuentra el elemento más pequeño en el arreglo
                if (a[small] > a[j]) { // compara el elemento más pequeño con el siguiente elemento
                    small = j;  // actualiza el indice del elemento más pequeño
                }
            }
            // intercambia el elemento más pequeño con el primer elemento
            int temp = a[i];
            a[i] = a[small];
            a[small] = temp;    // intercambia los elementos
        }
    }

    static void printArr(int[] a) { // funcion para imprimir el array
        for (int i = 0; i < a.Length; i++) {    // recorre todo el arreglo
            Console.Write(a[i] + " "); // imprime el elemento
        }
    }

    static void Main(string[] args) {
        int[] a = { 65, 26, 13, 23, 12 };    // arreglo desordenado
        Console.WriteLine("Arrelo antes de ser ordenado: ");
        printArr(a);
        selection(a);
        Console.WriteLine("\nArreglo después de ser ordenado: ");
        selection(a);
        printArr(a);
    }
}