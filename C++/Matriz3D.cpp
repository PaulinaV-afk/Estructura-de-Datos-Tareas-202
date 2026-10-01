#include <iostream>
#include <vector>

int main() {
    // Implementacion
    int r = 3; int c = 3;
    std::vector<int> arr(r * c, 0);

    // Matriz iniciada y luego se asigna un valor
    std::vector<std::vector<int>> TwoDArr = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    }; // Almacenae elemnetos en array unidimensional ordenados por filas

    int k = 0;
    for (int x = 0; x < r; x++) {
        for (int y = 0; y < c; y++) {
            k = x * r + y;
            arr[k] = TwoDArr[x][y];
            k = k + 1;
        }
    }

    std::cout << "Los elementos del array bidimensional son:\n";
    for (const auto& row : TwoDArr) {
        for (int ele : row) {
            std::cout << ele << " "; // Mostrar los elementos de la fila separados por espacios
        }
        std::cout << "\n"; // Ir a la siguiente linea despues de mostrar una fila
    }

    std::cout << "\nLos elementos del array unidimensional son:\n";
    // Imprimir los elemenos del array unidimensional
    for (int x = 0; x < r; x++) {
        for (int y = 0; y < c; y++) {
            std::cout << arr[x * r + y] << " ";
        }
    }

    return 0;
}