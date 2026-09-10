using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> inputArr = new List<int> { 10, 20, 40, 50 };
        int targetIndex = 2;
        int elementToInsert = 30;

        Console.WriteLine("Antes de insertar, el array es:");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }

        // Insertando en el índice targetIndex
        inputArr.Insert(targetIndex, elementToInsert);

        Console.WriteLine("\nDespués de insertar " + elementToInsert + " en la posición " + targetIndex + ":");
        for (int j = 0; j < inputArr.Count; j++) {
            Console.Write(inputArr[j] + " ");
        }
    }
}