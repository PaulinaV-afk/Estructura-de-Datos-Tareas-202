import java.util.ArrayList;
import java.util.Arrays;

public class recorridoInverso {
    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(12, 34, 10, 6, 40));
        int s = inputArr.size();

        System.out.println("Recorrido inverso del array:");
        for (int j = s - 1; j >= 0; j--) {
            System.out.println("Elemento en el índice " + j + ": " + inputArr.get(j));
        }
    }
}
