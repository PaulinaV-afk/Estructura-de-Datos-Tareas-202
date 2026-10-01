public class Intercambio2Elem {

    // Función para intercambiar dos elementos en el arreglo
    public static void swap(int[] a, int j, int k) { // intercambia los elementos
        int temp = a[j];
        a[j] = a[k];
        a[k] = temp; // intercambia los elementos
    }

    // Función para particionar el arreglo alrededor de un pivote
    public static int partition(int[] a, int l, int h) {
        int pivot = a[h];
        int i = l - 1;
        for (int j = l; j < h; j++) {
            if (a[j] <= pivot) {
                i += 1;
                swap(a, i, j);
            }
        }
        swap(a, i + 1, h);
        return i + 1;
    }

    // Implementación de la función QuickSort
    public static void qckSort(int[] a, int l, int h) { // función principal de QuickSort
        if (l < h) { // si el índice izquierdo es menor que el derecho
            // pi es el índice de partición, regresa el índice del pivote
            int pi = partition(a, l, h); // particiona el arreglo
            // llamadas recursivas para los elementos menores
            // y mayores o iguales a los elementos
            qckSort(a, l, pi - 1); // llamada recursiva para los elementos menores que el pivote
            qckSort(a, pi + 1, h); // llamada recursiva para los elementos mayores o iguales que el pivote
        }
    }

    // Código para probar la implementación de QuickSort
    public static void main(String[] args) { // punto de entrada del programa
        int[] a = {10, 7, 8, 9, 1, 5}; // arreglo desordenado
        int size = a.length; // tamaño del arreglo
        System.out.println("El arreglo antes de ordenarlo: ");
        for (int v : a) { // imprime el arreglo
            System.out.print(v + " ");
        }
        System.out.println(); // salto de línea
        qckSort(a, 0, size - 1);
        System.out.println("El arreglo después de ordenarlo: ");
        for (int v : a) { // imprime el arreglo ordenado
            System.out.print(v + " ");
        }
    }
}