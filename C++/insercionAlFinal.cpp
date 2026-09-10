#include <iostream>
#include <vector>

int main() {
    std::vector<int> inputArr = {10, 20, 30};
    int elementToInsert = 40;

    std::cout << "Antes de insertar, el array es:\n";
    for (size_t j = 0; j < inputArr.size(); j++) {
        std::cout << inputArr[j] << " ";
    }

    // Insertando elemento al final
    inputArr.push_back(elementToInsert);

    std::cout << "\nDespués de insertar " << elementToInsert << " al final, el array es:\n";
    for (size_t j = 0; j < inputArr.size(); j++) {
        std::cout << inputArr[j] << " ";
    }
    return 0;
}