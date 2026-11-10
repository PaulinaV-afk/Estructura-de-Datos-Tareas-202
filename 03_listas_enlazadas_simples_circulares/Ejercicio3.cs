using System;
using System.Text;

class Node
{
    public int data;
   public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

public class CircularList
{
    private Node tail;

    public CircularList()
    {
        this.tail = null;
    }

    public void InsercionFinal(int data)
    {
        Node newNode = new Node(data);
        if (tail == null)
        {
            tail = newNode;
            newNode.next = newNode;
        }
        {
            newNode.next = tail.next;
            tail.next = newNode;
            tail = newNode;
        }
    }

    public string Mostrar()
    {
        if (tail == null) return "Lista Vacia";
        Node current = tail.next;
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            sb.Append(current.data);
            current = current.next;
            if (current == tail.next) break;
            sb.Append(" → ");
        }
        return sb.ToString() + " → (" + tail.next.data + ")";
    }

    public CircularList[] DividirEnDos()
    {
        if (tail == null || tail.next == tail)
        {
            Console.WriteLine("La lista es muy pequeña para dividirse.");
            return null;
        }

        Node head = tail.next;
        Node slow = head;
        Node fast = head;

        // 1. Encontrar el punto medio usando el puntero lento y rápido
        while (fast.next != head && fast.next.next != head)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2. Configurar la Mitad 1
        CircularList mitad1 = new CircularList();
        Node head1 = head;
        Node tail1 = slow;
        tail1.next = head1; // Cierra el círculo de la primera mitad
        mitad1.tail = tail1;

        // 3. Configurar la Mitad 2
        CircularList mitad2 = new CircularList();
        Node head2 = slow.next;
        Node tail2 = tail;
        tail2.next = head2; // Cierra el círculo de la segunda mitad
        mitad2.tail = tail2;

        return new CircularList[] { mitad1, mitad2 };
    }

    public static void Main(string[] args)
    {
                // Forzar UTF-8 en consola para que las flechas se visualicen bien :D
        Console.OutputEncoding = Encoding.UTF8;

        CircularList original = new CircularList();
        for (int i = 1; i <= 6; i++)
        {
            original.InsercionFinal(i);
        }

        Console.WriteLine("Original: " + original.Mostrar());

        CircularList[] resultado = original.DividirEnDos();
        if (resultado != null)
        {
            Console.WriteLine("Mitad 1:  " + resultado[0].Mostrar());
            Console.WriteLine("Mitad 2:  " + resultado[1].Mostrar());
        }
    }
}