using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class PilaLista{
    private class Nodo{
        public int Dato{ get; set;}
        public Nodo Siguiente{ get; set;}
        public Nodo(int dato){
            Dato = dato;
            Siguiente = null;
        }
    }

    private Nodo top = null;

    public void Push(int item){
        Nodo nuevoNodo = new Nodo(item);
        nuevoNodo.Siguiente = top;
        top = nuevoNodo;
    }

    public int Pop(){
        if (isEmpty()){
            Console.WriteLine("Error: Stack Underflow (Pila Vacia).");
            return -1;  
        }
        int datoExtraido = top.Dato;
        top = top.Siguiente;
        return datoExtraido;
    }

    public int Peek(){
        if (isEmpty()){
            Console.WriteLine("La pila esta vacia.");
            return -1;
        }
        return top.Dato;
    }

    public bool isEmpty() => top == null;

    public void Display(){
        Nodo actual = top;
        Console.WriteLine("Pila cima a base: ");
        while(actual != null){
            Console.WriteLine(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public static void Main(){
        PilaLista miPila =  new PilaLista();
        //prueba d borde
        miPila.Pop();
        miPila.Peek();
        Console.WriteLine(" ");

        Console.WriteLine("Salida: ");
        miPila.Push(10);
        miPila.Push(20);
        miPila.Push(30);
        
        Console.WriteLine("Elemento Superior: "+ miPila.Peek());
        Console.WriteLine("Extraer elemento: "+ miPila.Pop());
        Console.WriteLine("Elemento Superior: "+ miPila.Peek());
        Console.WriteLine(" ");

        //estado de la pila al final (recorrido d display)
        miPila.Display();
    }
}