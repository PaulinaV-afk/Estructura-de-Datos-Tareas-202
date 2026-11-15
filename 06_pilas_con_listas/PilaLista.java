public class PilaLista{
    private static class Nodo{
        int dato;
        Nodo siguiente;
        Nodo(int dato) {
            this.dato = dato; 
            this.siguiente = null;
        }

    }

    private Nodo top = null;

    public void push(int item){
        Nodo nuevoNodo = new Nodo(item);
        nuevoNodo.siguiente = top;
        top = nuevoNodo;
    }

    public int pop(){
        if(isEmpty()){
            System.out.println("Error: Stack Underflow (Pila vacia).");
            return -1;
        }
        int datoExtraido = top.dato;
        top = top.siguiente;
        return  datoExtraido;
    }

    public int peek(){
        if(isEmpty()){

            System.out.println("La pila esta vacia.");
            return -1;
        }
        return top.dato;
    }

    public boolean isEmpty(){
        return  top == null;
    }

    public void display(){
        Nodo actual = top;
        System.out.println("Pila (cima a base:)");
        while (actual != null) {
            System.out.println(actual.dato+" ");
            actual = actual.siguiente;
        }
        System.out.println();
    }

    public static void main(String[] args){
        PilaLista miPila = new PilaLista();
        
        miPila.push(10);
        miPila.push(20);
        miPila.push(30);

        System.out.println("Elemento Superior:"+miPila.peek());
        System.out.println("Extraer elemento:"+miPila.pop());
        System.out.println("Elemento Superior:"+miPila.peek());
    }
}
