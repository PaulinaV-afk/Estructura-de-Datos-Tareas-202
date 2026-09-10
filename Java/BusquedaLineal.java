import java.util.ArrayList;
import java.util.Arrays;

public class BusquedaLineal{
    public static int findEle(ArrayList<Integer> arr, int targetValue) {
        for (int i = 0; i < arr.size(); i++) {
            if (arr.get(i) == targetValue) {
                return i;
            }
        }
        return -1;
    }

    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(12, 34, 10, 6, 40, 89, 98, 57, 19, 69)); // arrays de entrada
        int targetElement = 40; // elemento objetivo a encontrar

        // operación de búsqueda
        int idx = findEle(inputArr, targetElement);
        if (idx != -1) {
            System.out.println("El elemento se encuentra en la posición: " + (idx + 1));
        } else {
            System.out.println("El elemento no se encuentra.");
        }
    }
}