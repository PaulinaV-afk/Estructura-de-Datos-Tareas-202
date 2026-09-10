using System;
using System.Collections.Generic;

class Program {
    static int FindEle(List<int> inpuptArr, int s, int targetEle) {
        for (int j = 0; j < s; j++) {
            if (inpuptArr[j] == targetEle) { // aplicando búsqueda lineal
                return j; // elemento encontrado en el índice j
            }
        }
        // no se encuentra el elemento objetivo
        return -1;
    }

    static void Main() {
        List<int> inputArr = new List<int> { 12, 34, 10, 6, 40, 89, 98, 57, 19, 69 };
        int targetElement = 40;
        int s = inputArr.Count;

        // operación de búsqueda
        int idx = FindEle(inputArr, s, targetElement);
        if (idx != -1) {
            Console.WriteLine("El elemento se encuentra en la posición: " + (idx + 1));
        } else {
            Console.WriteLine("No se encuentra el elemento.");
        }
    }
}
