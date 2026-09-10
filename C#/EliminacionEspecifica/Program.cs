using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> inputArr = new List<int> { 10, 20, 30, 40, 50 };
        int targetValue = 30;

        Console.WriteLine("Antes de eliminar, el array es:");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }

        // Eliminación específica por valor
        inputArr.Remove(targetValue);

        Console.WriteLine("\nDespués de eliminar " + targetValue + ", el array es:");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }
    }
}
