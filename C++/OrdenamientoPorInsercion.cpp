#include <iostream>
#include <vector>

using namespace std;

void insertionSort(vector<int>& a) {
    for (size_t i = 1; i < a.size(); i++) {
        int temp = a[i];
        // mueve los elementos mayores que temp
        // a una posicion mas adelante que su posicion actual
        int j = i - 1;
        while (j >= 0 && temp < a[j]) {
            a[j + 1] = a[j];
            j = j - 1;
        }
        a[j + 1] = temp;
    }
}

void printArr(vector<int>& a) { // funcion para imprimir el array
    for (size_t i = 0; i < a.size(); i++) {
        cout << a[i] << " ";
    }
}

int main() {
    vector<int> a = {70, 15, 2, 51, 60};
    cout << "Antes de ordenar los elementos del arreglo: " << endl;
    printArr(a);
    insertionSort(a);
    cout << "\nDespues de arreglos de los elementos del arreglo: " << endl;
    printArr(a);
    return 0;
}