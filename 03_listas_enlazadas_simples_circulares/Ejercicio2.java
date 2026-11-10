
class Node{
    int data;
    Node next;

    public Node(int data){
        this.data = data;
        this.next = null;
    }
}

public class Ejercicio2{
    private Node tail;

    public Ejercicio2(){
        this.tail = null;
    }
    
    public void insercionInicio(int data){
        Node newNode = new Node(data);
        if(tail == null){
            tail = newNode;
            newNode.next = newNode; //el unico ndo apunta a si mismo
        }else{
            newNode.next = tail.next; //tail.next es la cabeza actu
            tail.next = newNode;
        }
        System.out.println("Insertando al inicio: "+ data);
    }

    //insercion al final
    public void insercionAlFinal(int data){
        Node newNode = new Node(data);
        if( tail == null){
            tail = newNode; // cola == nuevo ndo
            newNode.next = newNode;//igual unico ndo apunta asi mismo
        }else{
            newNode.next = tail.next; // nvo ndo a punta a la cabeza act
            tail.next = newNode;// la cola antigua apunta al nvo ndo
            tail = newNode; // cola = a nvo nodo
        }
        System.out.println("Insertando al final: "+ data);
    }

    //mostrar lista
    public String mostrar(){
        if( tail == null){
            System.out.println("Lista Vacia.");
        }
        Node current =tail.next; //la cabeza siempre es el sig de la cola o tail.next
        StringBuilder sb = new StringBuilder();

        while(true){
            sb.append(current.data);
            current = current.next;
            if(current == tail.next){
             break;
            }
            sb.append(" -> ");
            
        }
        return sb.toString() + " -> ("+ tail.next.data+")";
    }

    public static void main(String[]arg){
        Ejercicio2 cll = new Ejercicio2();
        cll.insercionAlFinal(10);
        cll.insercionAlFinal(20);
        cll.insercionAlFinal(30);
        System.out.println("Lista: "+ cll.mostrar());

        //insertar al inicio(5)
        cll.insercionInicio(5);
        System.out.println("Insertar inicio (5): "+ cll.mostrar());

        //insertar al final (40)
        cll.insercionAlFinal(40);
        System.out.println("Insertar al final (40): "+ cll.mostrar());
        
    }
    //no supe con la flechas  y en la compilacion todavia salen las otras :'b
}
