using System;

public class ColaListas{
    private class Nodo{
        public int Dato;
        public Nodo Siguiente;
        public Nodo(int dato){Dato = dato; Siguiente =  null;}
    }

    private Nodo front = null;
    private Nodo rear =  null;

    public void Encolar(int item){
        Nodo nuevo = new Nodo(item);
        if(front == null){
            front = rear = nuevo;
        }
        else{
            rear.Siguiente = nuevo;
            rear = nuevo;
        }
    }

    public int Desencolar(){
        if(front == null){
            return -1;
        }
        int valor = front.Dato;
        front = front.Siguiente;
        if(front == null){
            rear = null;
        }
        return valor;
    }

    public void Mostrar(){
        Nodo actual = front;
        while(actual != null){
            Console.Write(actual.Dato+" ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public static void Main(String[] args){
        ColaListas c = new ColaListas();
        c.Encolar(100);
        c.Encolar(200);
        c.Encolar(300);
        c.Mostrar();
        Console.WriteLine("Desenlocado: "+c.Desencolar());
        c.Mostrar();
    }
}