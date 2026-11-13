public  class PilaArreglo{
    private static final int MAX_SIZE = 3; // Reduc para hacer pruebas anterirormente 100
    private int[] stack = new int[MAX_SIZE];
    private int top = -1;

    public void push(int item){
        if(isFull()){
            System.out.println("!Error: Stack Overflow. La pila se encuentra llena.");
        }else{
            stack[++top] = item;
            
        }
    }

    public int pop(){
        if(isEmpty()){
           System.out.println("!Error: Stack Underflow. La pila Se encuentra vacia");
           return -1;
        }else{
            
            return stack[top--];
        }
    }

    public int peek(){
        if(isEmpty()){
            System.err.println("!Error: La pila se encuentra vacia.");
            return -1;
        }else{
            return stack[top];
        }
    }

    public boolean isEmpty(){

        return top == -1;
    }

    public boolean isFull(){
        return top == MAX_SIZE - 1;
    }

    public static void main(String[] args){
        PilaArreglo miPila = new PilaArreglo();

        miPila.push(10);
        miPila.push(20);
        miPila.push(30);

        System.out.println("Elemento Superior: " + miPila.peek());

        System.out.println("Extraer elemento:" + miPila.pop());

        System.out.println("Elemento Superior: " + miPila.peek());
   
    }
}

//Lo q use pa pruebas

//         System.out.println("========== PRUEBAS =========");
// System.out.println("Estado inicial:");
// System.out.println("La pila esta vacia?" + miPila.isEmpty());
// System.out.println("Probando Stack Underflow:");
// miPila.pop();
// System.out.println("Insertando hasta llenar la pila:");
// miPila.push(10);
// miPila.push(20);
// miPila.push(30);
// System.out.println("Probando Overflow:");
// miPila.push(40);
// System.out.println("Probando peek:");
// System.out.println("Elemento en la cima(peek):" + miPila.peek());
// System.out.println("Vaciado de la pila usando extracciones(pop):");
//  while(!miPila.isEmpty()){
// miPila.pop();
//}
//System.out.println("Estado :");
//System.out.println("La pila esta vacia?" + miPila.isEmpty());