using System;
using System.IO.Pipelines;

public class ColaArreglo{
    private const int MAXSIZE = 5;
    private int[] queue = new int[MAXSIZE];
    private int front = -1;
    private int rear = -1;

    public void insertar(int elemento){
       if(rear == MAXSIZE - 1){
         return;
        }
        if(front == -1){
            front = 0;
        }

        queue[++rear] = elemento;
        Console.WriteLine("Elemento insertado correctamente.");
   }

   public int eliminar(){
        if(front == -1 || front > rear){
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
        if(front == -1 || front > rear){
            return;
        }
        for(int i = front; i <= rear; i++){
            Console.WriteLine(queue[i]+" ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args){
        ColaArreglo c = new ColaArreglo();
        c.insertar(10);
        c.insertar(20);
        c.mostrar();
        c.eliminar();
        c.mostrar();
    }
}

