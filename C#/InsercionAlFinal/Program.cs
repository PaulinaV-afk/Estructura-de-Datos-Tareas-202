using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> inputArr = new List<int> { 10, 20, 30 };
        int elementToInsert = 40;

        Console.WriteLine("Antes de insertar, el array es:");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }

        // Insertando elemento al final
        inputArr.Add(elementToInsert);

        Console.WriteLine("\nDespués de insertar " + elementToInsert + " al final, el array es:");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }
    }
}
