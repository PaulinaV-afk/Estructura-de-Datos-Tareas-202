using System;
using System.Collections.Generic;

class Program{
    static void Main(){
    List<int> inputArr = new List<int>{11, 21, 31, 41, 51, 61};

    Console.WriteLine("Antes de la eliminacion el array es: ");
    for (int j = 0; j < inputArr.Count; j++) {
        Console.WriteLine(inputArr[j] + " ");
    }

    inputArr.RemoveAt(0);

    Console.WriteLine("\nDespues de la eliminacion el array es: ");
    for (int j = 0; j < inputArr.Count; j++) {
        Console.WriteLine(inputArr[j] + " ");
        }



    }
    }
