class Node {
    int data;
    Node next;

    public Node(int data) {
        this.data = data;
        this.next = null;
    }
}

class SinglyLinkedList {
    Node head;

    public void append(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
        } else {
            Node temp = head;
            while (temp.next != null) {
                temp = temp.next;
            }
            temp.next = newNode;
        }
    }

    public void printList() {
        Node temp = head;
        StringBuilder sb = new StringBuilder();
        while (temp != null) {
            sb.append(temp.data);
            if (temp.next != null) {
                sb.append(" → ");
            }
            temp = temp.next;
        }
        System.out.println(sb.toString());
    }

    // Método para invertir la lista enlazada in-place
    public void reverse() {
        Node prev = null;
        Node current = head;
        Node nextNode = null;

        while (current != null) {
            nextNode = current.next; // Guarda temporalmente el siguiente nodo
            current.next = prev;     // Invierte el puntero del nodo actual hacia atrás
            prev = current;          // Avanza 'prev'una posición
            current = nextNode;      // Avanza çurrent'una posición
        }
        head = prev; // Actualiza la cabeza de la lista al nuevo primer nodo
    }
}

public class Ejercicio4{
    public static void main(String[] args) {
        SinglyLinkedList list = new SinglyLinkedList();
        list.append(1);
        list.append(2);
        list.append(3);
        list.append(4);
        list.append(5);

        System.out.print("Lista original: ");
        list.printList();

        list.reverse();

        System.out.print("Lista invertida: ");
        list.printList();
    }
}