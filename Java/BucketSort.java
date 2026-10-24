import java.util.ArrayList;
import java.util.List;

public class BucketSort {
    public static void insertion_sort(List<Double> bukt) { //Funcion de ordenamiento por insercion
        for (int j = 1; j < bukt.size(); j++) {              //Iterar desde el segundo elemento hasta el final del arreglo
            double val = bukt.get(j);                        //Elemento actual a insertar
            int k = j - 1;                                   //Indice del elemento anterior
            while (k >= 0 && bukt.get(k) > val) {            //Mover los elementos mayores a la derecha
                bukt.set(k + 1, bukt.get(k));                //Desplazar elemento
                k = k - 1;                                   //Mover el sig elemento a la izquierda
            }
            bukt.set(k + 1, val);                            //Insertar el elemento actual en su posición correcta
        }
    }

    public static void bucket_sort(double[] inputArr) {      //Funcion de ordenamiento por cubetas
        int s = inputArr.length;                             //Numero de buckets
        List<List<double[]>> bucketArrRaw = new ArrayList<>();
        List<List<Double>> bucketArr = new ArrayList<>();
        for (int i = 0; i < s; i++) {
            bucketArr.add(new ArrayList<>());                //Crear una lista de buckets vacíos
        }

        for (double j : inputArr) {                          //Iterar sobre cada elemento del arreglo de entrada
            int bi = (int) (s * j);                          //Indice del bucket
            if (bi >= s) bi = s - 1;
            bucketArr.get(bi).add(j);                        //Agregar el elemento al bucket correspondiente
        }

        for (List<Double> bukt : bucketArr) {                //Iterar sobre cada bucket y ordenarlo usando insertion_sort
            insertion_sort(bukt);                            //Ordenar el bucket
        }

        int idx = 0;                                         //Indice para el arreglo de entrada
        for (List<Double> bukt : bucketArr) {                //Iterar sobre cada bucket
            for (double j : bukt) {                          //Iterar sobre cada elemento del bucket
                inputArr[idx] = j;                           //Colocar elemento ordenado en el arreglo de entrada
                idx += 1;                                    //Mover al siguiente indice
            }
        }
    }

    public static void main(String[] args) {
        //Ejemplo de uso
        double[] inputArr = {0.77, 0.16, 0.38, 0.25, 0.71, 0.93, 0.22, 0.11, 0.24, 0.67}; //Arreglo de entarda
        System.out.println("Arreglo antes de ser ordenado: ");//Imprime el arreglo antes de ser ordenado
        StringBuilder sb = new StringBuilder();
        for (double j : inputArr) sb.append(j).append(" ");
        System.out.println(sb.toString().trim());
        
        bucket_sort(inputArr);
        
        System.out.println("Arreglo después de ser ordenado: ");//Imprime el arreglo después de ser ordenado
        sb = new StringBuilder();
        for (double j : inputArr) sb.append(j).append(" ");
        System.out.println(sb.toString().trim());
    }
}