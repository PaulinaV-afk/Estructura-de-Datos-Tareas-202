#include <iostream>
#include <vector>

int findEle(const std::vector<int>& inpuptArr, int s, int targetEle) {
    for (int j = 0; j < s; j++) {
        if (inpuptArr[j] == targetEle) { // aplicando búsqueda lineal
            return j; // elemento encontrado en el índice j
        }
    }
    // no se encuentra el elemento objetivo
    return -1;
}

int main() {
    std::vector<int> inputArr = {12, 34, 10, 6, 40, 89, 98, 57, 19, 69};
    int targetElement = 40;
    int s = inputArr.size();
    
    // operación de búsqueda
    int idx = findEle(inputArr, s, targetElement);
    if (idx != -1) {
        std::cout << "El elemento se encuentra en la posición: " << (idx + 1) << std::endl;
    } else {
        std::cout << "No se encuentra el elemento." << std::endl;
    }
    return 0;
}