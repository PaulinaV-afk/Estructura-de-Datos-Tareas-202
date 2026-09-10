import java.util.ArrayList;
import java.util.Arrays;

public class InsercionAlFinal {
    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(10, 20, 30));
        int elementToInsert = 40;

        System.out.println("Antes de insertar, el array es:");
        for (int j = 0; j < inputArr.size(); j++) {
            System.out.print(inputArr.get(j) + " ");
        }

        // Insertando elemento al final
        inputArr.add(elementToInsert);

        System.out.println("\nDespués de insertar " + elementToInsert + " al final, el array es:");
        for (int j = 0; j < inputArr.size(); j++) {
            System.out.print(inputArr.get(j) + " ");
        }
    }
}
