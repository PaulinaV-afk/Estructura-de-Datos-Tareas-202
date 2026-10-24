using System;
using System.Collections.Generic;

class Program {
    static void insertion_sort(List<double> bukt) { //Funcion de ordenamiento por insercion
        for (int j = 1; j < bukt.Count; j++) {              //Iterar desde el segundo elemento hasta el final del arreglo
            double val = bukt[j];                          //Elemento actual a insertar
            int k = j - 1;                                 //Indice del elemento anterior
            while (k >= 0 && bukt[k] > val) {              //Mover los elementos mayores a la derecha
                bukt[k + 1] = bukt[k];                     //Desplazar elemento
                k = k - 1;                                 //Mover el sig elemento a la izquierda
            }
            bukt[k + 1] = val;                             //Insertar el elemento actual en su posición correcta
        }
    }

    static void bucket_sort(double[] inputArr) {           //Funcion de ordenamiento por cubetas
        int s = inputArr.Length;                           //Numero de buckets
        List<List<double>> bucketArr = new List<List<double>>();
        for (int i = 0; i < s; i++) {
            bucketArr.Add(new List<double>());             //Crear una lista de buckets vacíos
        }

        foreach (double j in inputArr) {                   //Iterar sobre cada elemento del arreglo de entrada
            int bi = (int)(s * j);                         //Indice del bucket
            if (bi >= s) bi = s - 1;
            bucketArr[bi].Add(j);                          //Agregar el elemento al bucket correspondiente
        }

        foreach (var bukt in bucketArr) {                  //Iterar sobre cada bucket y ordenarlo usando insertion_sort
            insertion_sort(bukt);                          //Ordenar el bucket
        }

        int idx = 0;                                       //Indice para el arreglo de entrada
        foreach (var bukt in bucketArr) {                  //Iterar sobre cada bucket
            foreach (double j in bukt) {                   //Iterar sobre cada elemento del bucket
                inputArr[idx] = j;                         //Colocar elemento ordenado en el arreglo de entrada
                idx += 1;                                  //Mover al siguiente indice
            }
        }
    }

    static void Main(string[] args) {
        //Ejemplo de uso
        double[] inputArr = { 0.77, 0.16, 0.38, 0.25, 0.71, 0.93, 0.22, 0.11, 0.24, 0.67 }; //Arreglo de entrada
        Console.WriteLine("Arreglo antes de ser ordenado: ");//Imprime el arreglo antes de ser ordenado
        Console.WriteLine(string.Join(" ", inputArr));
        bucket_sort(inputArr);
        Console.WriteLine("Arreglo después de ser ordenado: ");//Imprime el arreglo después de ser ordenado
        Console.WriteLine(string.Join(" ", inputArr));
    }
}
