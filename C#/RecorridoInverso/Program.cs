using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<int> inputArr = new List<int> { 12, 34, 10, 6, 40 };
        int s = inputArr.Count;

        Console.WriteLine("Recorrido inverso del array:");
        for (int j = s - 1; j >= 0; j--) {
            Console.WriteLine("Elemento en el índice " + j + ": " + inputArr[j]);
        }
    }
}
