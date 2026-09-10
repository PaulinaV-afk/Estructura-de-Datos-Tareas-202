#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector<int> inputArr = {10, 20, 30, 40, 50};
    int targetValue = 30;

    std::cout << "Antes de eliminar, el array es:\n";
    for (size_t j = 0; j < inputArr.size(); j++) {
        std::cout << inputArr[j] << " ";
    }

    // Eliminación específica por valor
    auto it = std::find(inputArr.begin(), inputArr.end(), targetValue);
    if (it != inputArr.end()) {
        inputArr.erase(it);
    }

    std::cout << "\nDespués de eliminar " << targetValue << ", el array es:\n";
    for (size_t j = 0; j < inputArr.size(); j++) {
        std::cout << inputArr[j] << " ";
    }
    return 0;
}