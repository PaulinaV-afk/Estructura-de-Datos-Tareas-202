import java.util.ArrayList;
import java.util.Arrays;

public class EliminacionEspecifica {
    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(10, 20, 30, 40, 50));
        int targetValue = 30;

        System.out.println("Antes de eliminar, el array es:");
        for (int j = 0; j < inputArr.size(); j++) {
            System.out.print(inputArr.get(j) + " ");
        }

        // Eliminación específica por valor
        inputArr.remove(Integer.valueOf(targetValue));

        System.out.println("\nDespués de eliminar " + targetValue + ", el array es:");
        for (int j = 0; j < inputArr.size(); j++) {
            System.out.print(inputArr.get(j) + " ");
        }
    }
}