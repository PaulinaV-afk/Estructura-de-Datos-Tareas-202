#include <iostream>
#include <vector>

using namespace std;

// Heapsort es un algoritmo de ordenamiento basado en un árbol binario llamado "heap".
// La idea es construir un heap máximo (max-heap) y luego extraer el mayor elemento
// (la raíz) para colocarlo al final del arreglo, repitiendo el proceso hasta ordenar todo.
void heapify(vector<int>& arr, int n, int i) {
    // Función para asegurar que el subárbol con raíz en el índice i
    // cumpla con la propiedad de heap máximo.
    int largest = i;        // Inicialmente, asumimos que la raíz es el mayor
    int left = 2 * i + 1;    // Índice del hijo izquierdo
    int right = 2 * i + 2;   // Índice del hijo derecho

    // Si el hijo izquierdo existe y es mayor que la raíz
    if (left < n && arr[left] > arr[largest]) {
        largest = left;
    }

    // Si el hijo derecho existe y es mayor que el mayor actual
    if (right < n && arr[right] > arr[largest]) {
        largest = right;
    }

    // Si el mayor no es la raíz, intercambiamos y seguimos ajustando recursivamente
    if (largest != i) {
        int temp = arr[i];
        arr[i] = arr[largest];
        arr[largest] = temp; // Intercambio
        heapify(arr, n, largest); // Ajustar el subárbol afectado
    }
}

void heapsort(vector<int>& arr) {
    // Función principal de Heapsort.
    // Ordena la lista arr en orden ascendente.
    int n = arr.size();

    // Paso 1: Construir un heap máximo
    for (int i = n / 2 - 1; i >= 0; i--) {
        heapify(arr, n, i);
    }

    // Paso 2: Extraer elementos uno por uno del heap
    for (int i = n - 1; i > 0; i--) {
        // Mover la raíz (máximo) al final
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;

        // Llamar heapify en el heap reducido
        heapify(arr, i, 0);
    }
}

int main() {
    // Ejemplo de uso
    vector<int> lista = {12, 11, 13, 5, 6, 7};
    cout << "Antes de ordenar los elementos del array son: ";
    for (int x : lista) cout << x << " ";
    cout << endl;

    heapsort(lista);

    cout << "\nDespués de ordenar el arreglo: ";
    for (int x : lista) cout << x << " ";
    cout << endl;
    return 0;
}