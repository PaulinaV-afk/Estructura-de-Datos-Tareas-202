using System;

class Program {
    static void bubbleSort(int[] a) {
        int s = a.Length;
        //Iternando por todos los elementos del array
        for (int j_outer = 0; j_outer < s; j_outer++) {
            bool isSwapped = false;
            //los ultimos elemntos ya estan en su puesto correspondiente
            for (int j = 0; j < s - j_outer - 1; j++) {
                //recorriendo el array de 0 a s - j - 1
                //intercambiando si el elemento encontrado es mayor
                //que el siguiente elemento
                if (a[j] > a[j + 1]) {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    isSwapped = true;
                }
            }
            if (!isSwapped) {
                break;
            }
        }
    }

    static void Main(string[] args) {
        //Codigo del controlador para la prueba anterior
        int[] a = { 15, 16, 11, 13, 14 };
        Console.WriteLine("Antes de ordenar los elementos del array son: ");
        foreach (int j in a) {
            Console.Write(j + " ");
        }

        bubbleSort(a);
        Console.WriteLine("\nDespues de ordenar los elementos del array son: ");
        for (int j = 0; j < a.Length; j++) {
            Console.Write(a[j] + " ");
        }
    }
}
