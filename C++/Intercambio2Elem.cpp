#include <iostream>
#include <vector>

// Función para intercambiar dos elementos en el arreglo
void swap(std::vector<int>& a, int j, int k) { // intercambia los elementos
    int temp = a[j];
    a[j] = a[k];
    a[k] = temp; // intercambia los elementos
}

// Función para particionar el arreglo alrededor de un pivote
int partition(std::vector<int>& a, int l, int h) {
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
void qckSort(std::vector<int>& a, int l, int h) { // función principal de QuickSort
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
int main() { // punto de entrada del programa
    std::vector<int> a = {10, 7, 8, 9, 1, 5}; // arreglo desordenado
    int size = a.size(); // tamaño del arreglo
    std::cout << "El arreglo antes de ordenarlo: \n";
    for (int v : a) { // imprime el arreglo
        std::cout << v << " ";
    }
    std::cout << std::endl; // salto de línea
    qckSort(a, 0, size - 1);
    std::cout << "El arreglo después de ordenarlo: \n";
    for (int v : a) { // imprime el arreglo ordenado
        std::cout << v << " ";
    }
    return 0;
}