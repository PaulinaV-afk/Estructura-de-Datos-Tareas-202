public class Matriz3D {
    public static void main(String[] args) {
        // Implementacion
        int r = 3; int c = 3;
        int[] arr = new int[r * c];

        // Matriz iniciada y luego se asigna un valor
        int[][] TwoDArr = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        }; // Almacenae elemnetos en array unidimensional ordenados por filas

        int k = 0;
        for (int x = 0; x < r; x++) {
            for (int y = 0; y < c; y++) {
                k = x * r + y;
                arr[k] = TwoDArr[x][y];
                k = k + 1;
            }
        }

        System.out.println("Los elementos del array bidimensional son:");
        for (int[] row : TwoDArr) {
            for (int ele : row) {
                System.out.print(ele + " "); // Mostrar los elementos de la fila separados por espacios
            }
            System.out.println(); // Ir a la siguiente linea despues de mostrar una fila
        }

        System.out.println("\nLos elementos del array unidimensional son:");
        // Imprimir los elemenos del array unidimensional
        for (int x = 0; x < r; x++) {
            for (int y = 0; y < c; y++) {
                System.out.print(arr[x * r + y] + " ");
            }
        }
    }
}