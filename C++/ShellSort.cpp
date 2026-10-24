#include <iostream>
#include <vector>

using namespace std;

class Shellsort {
public:
    // Una funcion de utilidad para imprimir una matriz de tamaño n
    static void displayArr(const vector<int>& imputArr) {
        for (int k : imputArr) {
            cout << k << " ";
        }
        cout << endl;
    }

    // Funcion para ordenar imputArr usando shellsort
    int sort(vector<int>& imputArr) {
        int size = imputArr.size();
        // Comience con un espacio grande y luego reduzca su espacio
        int gapSize = size / 2;
        while (gapSize > 0) {
            // Estamos implementando una ordenacion por insercion con un espacio de tamaño especifico
            // Los primeros elementos de espacio de la matriz imputArr[0..gapSize-1]
            // Ya en orden, ahora tenemos que seguir agregando
            // un elemento mas hasta que la matriz este completamente ordenada
            for (int j = gapSize; j < size; j++) {
                int val = imputArr[j];
                int k = j;
                while (k >= gapSize && imputArr[k - gapSize] > val) {
                    imputArr[k] = imputArr[k - gapSize];
                    k = k - gapSize;
                }
                imputArr[k] = val;
            }
            gapSize = gapSize / 2;
        }
        return 0;
    }
};

int main() {
    vector<int> imputArr = {36, 34, 43, 11, 15, 20, 28, 25};
    cout << "Antes de ser ordenados: " << endl;
    Shellsort::displayArr(imputArr);
    Shellsort obj;
    obj.sort(imputArr);
    cout << "Arreglo despues de ser ordenados: " << endl;
    Shellsort::displayArr(imputArr);
    return 0;
}