using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Programa para eliminar un elemento al final
        List<int> inputArr = new List<int> { 11, 21, 31, 41, 51, 61 };
        Console.WriteLine("Antes de eliminar, el array es: ");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }

        // Eliminando el elemento al final
        if (inputArr.Count > 0) {
            inputArr.RemoveAt(inputArr.Count - 1);
        }

        Console.WriteLine("\nDespués de eliminar, el array es: ");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }
    }
}