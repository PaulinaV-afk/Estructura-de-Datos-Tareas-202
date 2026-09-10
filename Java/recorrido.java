import java.util.ArrayList;
import java.util.Arrays;

public class recorrido {
    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(12, 34, 10, 6, 40));
        int s = inputArr.size();

        System.out.println("Recorrido del array:");
        for (int j = 0; j < s; j++) {
            System.out.println("Elemento en el índice " + j + ": " + inputArr.get(j));
        }
    }
}