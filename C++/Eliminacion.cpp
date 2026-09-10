#include <iostream>
#include <vector>

int main(){
    std::vector<int> inputArr = {11, 21, 31, 41, 51, 61};

    std::cout << "Antes de la eliminacion el array es: \n";
    for(size_t j = 0; j < inputArr.size(); j++){
        std::cout << inputArr[j] << " ";
    }
    inputArr.erase(inputArr.begin());
    std::cout << "\nDespues de la eliminacion el array es: \n";
    for(size_t j = 0; j < inputArr.size(); j++){
        std::cout << inputArr[j] << " ";
    }
    return 0;
}