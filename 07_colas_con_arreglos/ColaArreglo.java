import java.util.Scanner;

public class ColaArreglo{
    private static final int MAXSIZE = 5;
    private int[] queue = new int[MAXSIZE];
    private int front = -1;
    private int rear = -1;

    public void insertar(int elemento){
        if(rear== MAXSIZE - 1){
            return;
        }
        if(front == -1){
            front = 0;
        }
        queue[++rear] = elemento;
        System.out.println("Elemento insertado correctamente.");
    }

    public int eliminar(){
        if(front == -1|| front>rear){
            return -1;
        }
        int eliminado = queue[front];
        if(front == rear){
            front = -1;
            rear = -1;
        }else{
            front++;
        }
        return eliminado;
    }

    public void mostrar(){
        if(front == -1||front>rear){
            return;
        }
        for(int i = front;i <= rear; i++){
            System.out.println(queue[i]+" ");
        }
        System.out.println();
    }

    public static void main(String[] args) {
        ColaArreglo cola = new ColaArreglo();

        cola.insertar(10);
        cola.insertar(20);
        cola.insertar(30);
        cola.mostrar();
        cola.eliminar();
        cola.mostrar();
    }
}