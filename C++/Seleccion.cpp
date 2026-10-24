#include <iostream>
#include <vector>

using namespace std;

void selection(vector<int>& a) { // funcion para implementar el algoritmo de selección
    for (size_t i = 0; i < a.size(); i++) { // recorre todo el arreglo
        size_t small = i; // indice del elemento más pequeño
        for (size_t j = i + 1; j < a.size(); j++) { // encuentra el elemento más pequeño en el arreglo
            if (a[small] > a[j]) { // compara el elemento más pequeño con el siguiente elemento
                small = j; // actualiza el indice del elemento más pequeño
            }
        }
        // intercambia el elemento más pequeño con el primer elemento
        int temp = a[i];
        a[i] = a[small];
        a[small] = temp; // intercambia los elementos
    }
}

void printArr(vector<int>& a) { // funcion para imprimir el array
    for (size_t i = 0; i < a.size(); i++) { // recorre todo el arreglo
        cout << a[i] << " "; // imprime el elemento
    }
}

int main() {
    vector<int> a = {65, 26, 13, 23, 12}; // arreglo desordenado
    cout << "Arrelo antes de ser ordenado: " << endl;
    printArr(a);
    selection(a);
    cout << "\nArreglo después de ser ordenado: " << endl;
    // Nota: El original llamaba selection(a) dos veces antes de imprimir en Python, replicando la estructura:
    selection(a);
    printArr(a);
    return 0;
}