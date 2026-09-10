import java.util.ArrayList;
import java.util.Arrays;

public class insercion {
    public static void main(String[] args) {
        ArrayList<Integer> numeros = new ArrayList<>(Arrays.asList(10, 20, 30, 40));
        numeros.add(1, 5);
        System.out.println(numeros);
    }
}