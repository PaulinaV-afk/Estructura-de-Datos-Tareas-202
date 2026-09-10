import java.util.ArrayList;
import java.util.Arrays;


public class Eliminacion {
    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(11, 21, 31, 41, 51, 61)); 

        System.out.println("Antes de la eliminacion el array es: ");
        for (int j = 0; j < inputArr.size(); j++) {
            System.out.println(inputArr.get(j) + " ");
        }

        inputArr.remove(0);

        System.out.println("\nDespues de la eliminacion el array es: ");
        for (int j = 0; j < inputArr.size(); j++) {
            System.out.println(inputArr.get(j) + " ");
        }
    }
}