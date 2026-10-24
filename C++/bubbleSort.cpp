#include <iostream>
#include <vector>

using namespace std;

void bubbleSort(vector<int>& a) {
    int s = a.size();
    // Iternando por todos los elementos del array
    for (int j_outer = 0; j_outer < s; j_outer++) {
        bool isSwapped = false;
        // los ultimos elementos ya estan en su puesto correspondiente
        // recorriendo el array de 0 a s - j - 1
        for (int j = 0; j < s - j_outer - 1; j++) {
            // intercambiando si el elemento encontrado es mayor
            // que el siguiente elemento
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

int main() {
    // Codigo del controlador para la prueba anterior
    vector<int> a = {15, 16, 11, 13, 14};
    cout << "Antes de ordenar los elementos del array son: " << endl;
    for (int j : a) {
        cout << j << " ";
    }

    bubbleSort(a);
    cout << "\nDespues de ordenar los elementos del array son: " << endl;
    for (size_t j = 0; j < a.size(); j++) {
        cout << a[j] << " ";
    }
    return 0;
}