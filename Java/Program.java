import java.util.ArrayList;
import java.util.Arrays;

public class Program {
    public static int findEle(ArrayList<Integer> inpuptArr, int s, int targetEle) {
        for (int j = 0; j < s; j++) {
            if (inpuptArr.get(j) == targetEle) { // aplicando búsqueda lineal
                return j; // elemento encontrado en el índice j
            }
        }
        // no se encuentra el elemento objetivo
        return -1;
    }

    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(12, 34, 10, 6, 40, 89, 98, 57, 19, 69));
        int targetElement = 40;
        int s = inputArr.size();

        // operación de búsqueda
        int idx = findEle(inputArr, s, targetElement);
        if (idx != -1) {
            System.out.println("El elemento se encuentra en la posición: " + (idx + 1));
        } else {
            System.out.println("No se encuentra el elemento.");
        }
    }
}