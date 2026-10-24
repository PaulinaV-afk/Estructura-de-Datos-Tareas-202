#include <iostream>
#include <vector>
#include <algorithm>
#include <iomanip>

using namespace std;

void insertion_sort(vector<double>& bukt) { // Funcion de ordenamiento por insercion
    for (size_t j = 1; j < bukt.size(); j++) { // Iterar desde el segundo elemento hasta el final del arreglo
        double val = bukt[j];                 // Elemento actual a insertar
        int k = (int)j - 1;                   // Indice del elemento anterior
        while (k >= 0 && bukt[k] > val) {     // Mover los elementos mayores a la derecha
            bukt[k + 1] = bukt[k];            // Desplazar elemento
            k = k - 1;                        // Mover el sig elemento a la izquierda
        }
        bukt[k + 1] = val;                    // Insertar el elemento actual en su posición correcta
    }
}

void bucket_sort(vector<double>& inputArr) { // Funcion de ordenamiento por cubetas
    int s = inputArr.size();                 // Numero de buckets
    vector<vector<double>> bucketArr(s);     // Crear una lista de buckets vacíos

    for (double j : inputArr) {              // Iterar sobre cada elemento del arreglo de entrada
        int bi = (int)(s * j);               // Indice del bucket
        if (bi >= s) bi = s - 1;
        bucketArr[bi].push_back(j);          // Agregar el elemento al bucket correspondiente
    }

    for (auto& bukt : bucketArr) {           // Iterar sobre cada bucket y ordenarlo usando insertion_sort
        insertion_sort(bukt);                // Ordenar el bucket
    }

    int idx = 0;                             // Indice para el arreglo de entrada
    for (auto& bukt : bucketArr) {           // Iterar sobre cada bucket
        for (double j : bukt) {              // Iterar sobre cada elemento del bucket
            inputArr[idx] = j;               // Colocar elemento ordenado en el arreglo de entrada
            idx += 1;                        // Mover al siguiente indice
        }
    }
}

int main() {
    // Ejemplo de uso
    vector<double> inputArr = {0.77, 0.16, 0.38, 0.25, 0.71, 0.93, 0.22, 0.11, 0.24, 0.67}; // Arreglo de entrada
    cout << "Arreglo antes de ser ordenado: " << endl; // Imprime el arreglo antes de ser ordenado
    for (double j : inputArr) cout << j << " ";
    cout << endl;

    bucket_sort(inputArr);

    cout << "Arreglo después de ser ordenado: " << endl; // Imprime el arreglo después de ser ordenado
    for (double j : inputArr) cout << j << " ";
    cout << endl;
    return 0;
}