public class BubbleSort {
    public static void bubbleSort(int[] a) {
        int s = a.length;
        //Iternando por todos los elementos del array
        for (int j_outer = 0; j_outer < s; j_outer++) {
            boolean isSwapped = false;
            //los ultimos elemntos ya estan en su puesto correspondiente
            for (int j = 0; j < s - j_outer - 1; j++) {
                //recorriendo el array de 0 a s - j - 1
                //intercambiando si el elemento encontrado es mayor
                //que el siguiente elemento
                if (a[j] > a[j + 1]) {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    isSwapped = true;
                }
            }
            if (!isSwapped) {
                break;
            }
        }
    }

    public static void main(String[] args) {
        //Codigo del controlador para la prueba anterior
        int[] a = {15, 16, 11, 13, 14};
        System.out.println("Antes de ordenar los elementos del array son: ");
        for (int j : a) {
            System.out.print(j + " ");
        }

        bubbleSort(a);
        System.out.println("\nDespues de ordenar los elementos del array son: ");
        for (int j = 0; j < a.length; j++) {
            System.out.print(a[j] + " ");
        }
    }
}