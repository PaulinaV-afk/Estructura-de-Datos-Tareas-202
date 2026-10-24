using System;
using System.Linq;

class Program {
    // Programa para implementar Radix Sort
    // Una función que ordena arr[] según el dígito representado por exp.
    static void countingSort(int[] arr, int exp) { // exp es 10^i donde i es el dígito actual
        int s = arr.Length; // Tamaño del arreglo de entrada
        // El arreglo de salida que tendrá el arreglo ordenado
        // inicializando todos los elementos a 0
        int[] outputArray = new int[s]; // array de tamaño s
        int[] countArray = new int[10]; // array de conteo para dígitos (0-9)

        // almacenando el conteo de ocurrencias en countArray[]
        for (int j = 0; j < s; j++) { // j es el índice del arreglo de entrada
            int idx = arr[j] / exp; // Obtener el dígito actual
            countArray[idx % 10]++; // Incrementar el conteo del dígito
        }

        // Cambiar countArray[i] para que ahora contenga la posición real de este dígito en el arreglo de salida
        for (int j = 1; j < 10; j++) { // j es el índice del arreglo de conteo
            countArray[j] += countArray[j - 1]; // Acumular los conteos
        }

        // Construir el arreglo de salida
        int k = s - 1; // Índice del último elemento del arreglo de entrada
        while (k >= 0) { // j es el índice del arreglo de entrada
            int idx = arr[k] / exp; // Obtener el dígito actual
            outputArray[countArray[idx % 10] - 1] = arr[k]; // Colocar el elemento en la posición correcta
            countArray[idx % 10]--; // Decrementar el conteo
            k--; // Mover al siguiente elemento
        }

        // Copiar el arreglo de salida a arr[],
        // Por lo tanto, arr ahora contiene números ordenados
        for (int j = 0; j < arr.Length; j++) { // j es el índice del arreglo de entrada
            arr[j] = outputArray[j]; // Copiar el elemento al arreglo de entrada
        }
    }

    // Metodo principal para implementar Radix Sort
    static void radixSort(int[] arr) { // La función principal que ordena arr[] usando Radix Sort
        // Obtener el número máximo para saber el número de dígitos
        int max1 = arr.Max(); // Encontrar el valor máximo en el arreglo

        // Hacer un conteo de ordenamiento para cada dígito.
        // Aplicando counting sort para cada dígito.
        int exp = 1; // Exponente inicial (10^0)
        while (max1 / exp >= 1) { // Mientras queden dígitos por procesar
            countingSort(arr, exp); // Ordenar según el dígito actual
            exp *= 10; // Mover al siguiente dígito
        }
    }

    static void Main(string[] args) {
        // Ejemplo de uso
        int[] arr = { 171, 46, 76, 91, 803, 25, 3, 67 }; // Arreglo de entrada
        Console.WriteLine("Arreglo antes de ordenar: "); // Imprimir arreglo antes de ordenar
        for (int j = 0; j < arr.Length; j++) { // j es el índice del arreglo
            Console.Write(arr[j] + " "); // Imprimir elementos del arreglo
        }

        // Llamar a la función de ordenamiento Radix
        radixSort(arr); // Llamar a la función de ordenamiento Radix
        Console.WriteLine("\nDespués de ordenar el arreglo: "); // Imprimir el arreglo ordenado
        for (int j = 0; j < arr.Length; j++) { // j es el índice del arreglo
            Console.Write(arr[j] + " "); // Imprimir elementos del arreglo ordenado
        }
    }
}
