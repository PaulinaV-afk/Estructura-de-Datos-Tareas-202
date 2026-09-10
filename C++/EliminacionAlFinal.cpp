#include <iostream>
#include <vector>

int main() {
    // Programa para eliminar un elemento al final
    std::vector<int> inputArr = {11, 21, 31, 41, 51, 61};
    std::cout << "Antes de eliminar, el array es: \n";
    for (size_t j = 0; j < inputArr.size(); j++) {
        std::cout << inputArr[j] << " ";
    }

    // Eliminando el elemento al final
    inputArr.pop_back();
    std::cout << "\nDespués de eliminar, el array es: \n";
    for (size_t j = 0; j < inputArr.size(); j++) {
        std::cout << inputArr[j] << " ";
    }
    return 0;
}