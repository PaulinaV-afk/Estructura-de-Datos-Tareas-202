using System;
using System.Text;


public class Nodo
{
    public int Valor;
    public Nodo Siguiente;
    public Nodo(int Valor)
    {
        Valor = Valor;
        Siguiente = null;
    }
}

public class ListaEnlaz
{
        private Nodo cabeza;

    public void Agregar(int valor)
    {
        Nodo Nuevo = new Nodo(valor);
        if(cabeza == null) {cabeza = Nuevo; return; }
        Nodo actual = cabeza;
        while(actual.siguente != null)
            actual = actual.siguente = Nuevo;
    }
    //elim cabeza
    public bool EliminarPRI()
{
    if(cabeza == null) return false;
    cabeza = cabeza.siguente;
    return true;
}

//elim ultimo nodo
public bool EliminarUlti()
{
    if(cabeza == null) return false;
    if(cabeza.siguiente == null);
    actual = actual.siguiente;
    actual.siguiente = null;
    return true;
}

//elim por valor
public bool EliminarValor(int valor)
{
    if(cabeza == null) return false;
    if(cabeza.Valor == valor)
    {
        cabeza = cabeza.Siguiente.Siguente;
        return true;
    }
    Nodo actual = cabeza;
    while(actual.Siguiente != null && actual.Siguiente.Valor != valor)
        actual = actual.Siguiente;
    if(actual.Siguiente = null) return false;
    actual.Siguiente = actual.Siguiente.Siguiente;
    return true;
}

public override string ToString(){
    if(cabeza == null) return "(Lista Vacia)";
    StringBuilder sb = new StringBuilder();
    Nodo actual = cabeza;
    while(actual != null)
    {
        sb.Append(actual.Valor);
        if(actual.Siguiente != null) sb. Append(" → ");
        actual = actual.Siguiente;
    }
    return sb.ToString();
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding =Encoding.UTF8;
        ListaEnlaz lista = new ListaEnlaz();
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);

        Console.WriteLine("Lista inicial: " + lista);
        Console.WriteLine("Eliminar valor 30");
        lista.EliminarValor(30);
        Console.WriteLine("Resultado: " + lista);
    }
}}


