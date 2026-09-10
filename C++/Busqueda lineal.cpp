#include <iostream>
#include <vector>
#include <string>

int findEle(const std::vector<int>& arr, int targetValue) {
    for (size_t i = 0; i < arr.size(); i++) {
        if (arr[i] == targetValue) {
            return i;
        }
    }
    return -1;
}

int main() {
    std::vector<int> inputArr = {12, 34, 10, 6, 40, 89, 98, 57, 19, 69}; // arrays de entrada
    int targetElement = 40; // elemento a encontrar
    
    // operación de búsqueda
    int idx = findEle(inputArr, targetElement);
    if (idx != -1) {
        std::cout << "El elemento se encuentra en la posicion: " + std::to_string(idx + 1) << std::endl;
    } else {
        std::cout << "El elemento no se encuentra." << std::endl;
    }
    return 0;
}