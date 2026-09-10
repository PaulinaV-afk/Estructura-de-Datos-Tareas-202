import java.util.ArrayList;
import java.util.Arrays;

public class EliminacionAlFinal {
    public static void main(String[] args) {
        // Programa para eliminar un elemento al final
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(11, 21, 31, 41, 51, 61));
        System.out.println("Antes de eliminar, el array es: ");
        for (int j = 0; j < inputArr.size(); j++) {
            System.out.print(inputArr.get(j) + " ");
        }

        // Eliminando el elemento al final
        if (!inputArr.isEmpty()) {
            inputArr.remove(inputArr.size() - 1);
        }

        System.out.println("\nDespués de eliminar, el array es: ");
        for (int j = 0; j < inputArr.size(); j++) {
            System.out.print(inputArr.get(j) + " ");
        }
    }
}
