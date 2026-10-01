using System;

class Program
{
    static void Main()
    {
        // Implementacion
        int r = 3; int c = 3;
        int[] arr = new int[r * c];

        // Matriz iniciada y luego se asigna un valor
        int[][] TwoDArr = new int[][] {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        }; // Almacenae elemnetos en array unidimensional ordenados por filas

        int k = 0;
        for (int x = 0; x < r; x++)
        {
            for (int y = 0; y < c; y++)
            {
                k = x * r + y;
                arr[k] = TwoDArr[x][y];
                k = k + 1;
            }
        }

        Console.WriteLine("Los elementos del array bidimensional son:");
        foreach (int[] row in TwoDArr)
        {
            foreach (int ele in row)
            {
                Console.Write(ele + " "); // Mostrar los elementos de la fila separados por espacios
            }
            Console.WriteLine(); // Ir a la siguiente linea despues de mostrar una fila
        }

        Console.WriteLine("\nLos elementos del array unidimensional son:");
        // Imprimir los elemenos del array unidimensional
        for (int x = 0; x < r; x++)
        {
            for (int y = 0; y < c; y++)
            {
                Console.Write(arr[x * r + y] + " ");
            }
        }
    }
}
