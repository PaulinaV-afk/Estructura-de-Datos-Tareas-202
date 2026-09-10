using System;

class Program {
    static int BuscarBinaria(int[] arr, int valor) {
        int inicio = 0, fin = arr.Length - 1;
        while (inicio <= fin) {
            int medio = inicio + (fin - inicio) / 2;
            if (arr[medio] == valor) return medio;
            if (arr[medio] < valor) inicio = medio + 1;
            else fin = medio - 1;
        }
        return -1;
    }

    static void Main() {
        int[] numeros = { 10, 20, 30, 40, 50, 60 };
        Console.WriteLine("Elemento encontrado en el indice: " + BuscarBinaria(numeros, 40));
    }
}
