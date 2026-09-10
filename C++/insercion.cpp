#include <iostream>
#include <vector>

int main() {
    std::vector<int> numeros = {10, 20, 30, 40};
    numeros.insert(numeros.begin() + 1, 5);

    std::cout << "[";
    for (size_t i = 0; i < numeros.size(); i++) {
        std::cout << numeros[i] << (i < numeros.size() - 1 ? ", " : "");
    }
    std::cout << "]" << std::endl;

    return 0;
}