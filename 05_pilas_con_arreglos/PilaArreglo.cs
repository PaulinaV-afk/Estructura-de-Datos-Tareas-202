using System;
using System.ComponentModel;

public class PilaArreglo{
    private const int MAX_SIZE = 100;
    private int[] stack = new int[MAX_SIZE];
    private int top = -1;

    public void Push(int item){
        if (IsFull()){
            Console.WriteLine("Error: Stack Overflow (pila llena).");
        }else{
            stack[++top] = item;
        }
    }

    public int Pop(){
        if (IsEmpty()){
            Console.WriteLine("Error: Stack Underflow (pila vacia).");
            return -1;
        }else{
            return stack[top--];
        }
    }

    public int Peek(){
        if (IsEmpty()){
            Console.WriteLine("Pila Vacia.");
            return -1;
        }else{
            return stack[top];
        }
    }

    public bool IsEmpty() => top == -1;
    public bool IsFull() => top == MAX_SIZE - 1;

    public static void Main(){
        PilaArreglo miPila = new PilaArreglo();
        miPila.Push(10);
        miPila.Push(20);
        miPila.Push(30);

        Console.WriteLine("Elemento superior: "+ miPila.Peek());
        Console.WriteLine("Extrae elemento: "+ miPila.Pop());
        Console.WriteLine("Elemento superior: "+ miPila.Peek());

    }
}
