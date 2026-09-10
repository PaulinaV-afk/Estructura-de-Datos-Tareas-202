#include <iostream>
#include <vector>

int main() {
    std::vector<int> inputArr = {12, 34, 10, 6, 40};
    int s = inputArr.size();

    std::cout << "Recorrido del array:\n";
    for (int j = 0; j < s; j++) {
        std::cout << "Elemento en el índice " << j << ": " << inputArr[j] << std::endl;
    }
    return 0;
}