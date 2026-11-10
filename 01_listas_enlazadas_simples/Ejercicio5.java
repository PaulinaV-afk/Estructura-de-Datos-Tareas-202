class Node {
    int data;
    Node next;

    public Node(int data) {
        this.data = data;
        this.next = null;
    }
}

public class Ejercicio5 {
    private Node head;

    public Ejercicio5() {
        this.head = null;
    }

    public void insertarFinal(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            return;
        }
        Node current = head;
        while (current.next != null) {
            current = current.next;
        }
        current.next = newNode;
    }

    // Método para detectar y romper el ciclo con el algoritmo de Floyd
    public boolean detectarYRomperCiclo() {
        if (head == null || head.next == null) {
            return false;
        }

        Node slow = head;
        Node fast = head;
        boolean hayCiclo = false;

        // PASO 1: Detectar si existe un ciclo
        while (fast != null && fast.next != null) {
            slow = slow.next;          
            fast = fast.next.next;     

            if (slow == fast) {
                hayCiclo = true;
                break; 
            }
        }

        if (!hayCiclo) {
            return false;
        }

        // PASO 2: Encontrar el inicio del ciclo
        slow = head;
        
        if (slow == fast) {
            Node current = fast;
            while (current.next != fast) {
                current = current.next;
            }
            current.next = null; 
            return true;
        }

        while (slow.next != fast.next) {
            slow = slow.next;
            fast = fast.next;
        }

        // PASO 3: Romper el ciclo
        fast.next = null; 

        return true;
    }

    public String obtenerRepresentacion() {
        Node current = head;
        StringBuilder sb = new StringBuilder();
        int contadorSeguridad = 0; 
        while (current != null && contadorSeguridad < 20) {
            sb.append(current.data).append(" → ");
            current = current.next;
            contadorSeguridad++;
        }
        sb.append("NULL");
        return sb.toString();
    }

    public static void main(String[] args) {
        Ejercicio5 lista = new Ejercicio5();

        // Construir lista: 1 → 2 → 3 → 4 → 5
        for (int i = 1; i <= 5; i++) {
            lista.insertarFinal(i);
        }

        // Forzar manualmente el ciclo: que el nodo 5 apunte al nodo 3
        Node nodo3 = lista.head.next.next; 
        Node nodo5 = lista.head.next.next.next.next; 
        nodo5.next = nodo3; 

        // Salida exacta requerida para el estado con ciclo
        System.out.println("Ciclo: 1 → 2 → 3 → 4 → 5 (donde 5 apunta de regreso a 3)");

        // Ejecutar la detección y ruptura
        lista.detectarYRomperCiclo();

        // Salida exacta requerida tras romper el ciclo
        System.out.println("Resultado tras romper ciclo: " + lista.obtenerRepresentacion());
    }
}