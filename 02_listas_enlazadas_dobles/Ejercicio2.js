class Node{
    constructor(data){
        this.data = data;
        this.next = null;
        this.prev = null;
    }
}

class ListaEnlazadaDobOrd {
    constructor(){
        this.head = null;
        this.tail = null;
    }
    //para insertar manteniendo el orden
    insert(val){
        const newNode = new Node(val);

        //lista vacia
        if(this.head === null){
            this.head = newNode;
            this.tail = newNode;
            return;
        }

        //insertar(cabeza) al inicio
        if(val<this.head.data){
            newNode.next =this.head;
            this.head.prev = newNode;
            this.head = newNode;
            return;
        }

        //insertar al final o intermedio
        let current = this.head;
        while(current!== null && current.data<val){
            current = current.next;
        }

        //si current es null sig q es mayor q lo demas y va al final
        if(current == null){
            this.tail.next = newNode;
            newNode.prev = this.tail;
            this.tail = newNode;
        }

        //si no se inserta d forma intermedia
        else{
            let previousNode = current.prev;

            //act los 4 enlazes
            previousNode.next = newNode;
            newNode.prev = previousNode;
            newNode.next =current;
            current.prev =newNode;
        }
    }
    //imprimir
    printList(){
        let current = this.head;
        let result = [];
        while(current!==null){
            result.push(current.data);
            current = current.next
        }
        console.log(result.join(" ⇄ "));
    }
}

//pruebas :b
const lista = new ListaEnlazadaDobOrd();
lista.insert(10);
lista.insert(30);
lista.insert(50);

console.log("Lista inicial:");
lista.printList(); 
console.log("Insertando 25:");
lista.insert(25);
lista.printList();
console.log("Insertando 5 (al inicio):");
lista.insert(5);
lista.printList();
console.log("Insertando 100 (al final):");
lista.insert(100);
lista.printList();