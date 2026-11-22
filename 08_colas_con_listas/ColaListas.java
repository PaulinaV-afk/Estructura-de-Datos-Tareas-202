public class ColaListas{
    private static class Nodo {
        int dato;
        Nodo siguiente;
        Nodo(int dato){ this.dato = dato; this.siguiente = null;}

    }

    private Nodo front = null;
    private Nodo rear = null;

    public void encolar(int item){
        Nodo nuevo = new Nodo(item);
        if(estaVacia()){
            front = rear = nuevo;
        }else{
            rear.siguiente = nuevo;
            rear =  nuevo;
        }
    }

    public int desencolar(){
        if(estaVacia()){
            return -1;
        }
        int valor = front.dato;
        front = front.siguiente;
        if(front == null){
            rear = null;
        }
        return valor;
    }

    public void mostrar(){
        Nodo actual = front;
        while(actual != null){
            System.out.println(actual.dato+" ");
            actual = actual.siguiente;
        }
        System.out.println();
    }
    
    public boolean estaVacia(){
        return front == null;
    }

    public static void main(String[] args){
        ColaListas c = new ColaListas();
        c.encolar(100);
        c.encolar(200);
        c.encolar(300);
        c.mostrar();
        System.out.println("Desencolado: "+c.desencolar());
        c.mostrar();
    }
}
