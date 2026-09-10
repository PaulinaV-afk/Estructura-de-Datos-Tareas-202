using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Inserción c#
        List<int> inputArr = new List<int> { 12, 34, 10, 6, 40 };
        int elementToInsert = 25;
        int position = 2; // índice donde se insertará

        Console.WriteLine("Antes de insertar, el array es:");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }

        // Operación de inserción normal
        inputArr.Insert(position, elementToInsert);

        Console.WriteLine("\nDespués de insertar " + elementToInsert + " en el índice " + position + ", el array es:");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }
    }
}
